using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace PLC通讯基础控件项目.宏脚本.宏对象池
{
    /// <summary>
    /// 执行宏任务对象池
    /// 自动分配对象池任务为空
    /// </summary>
    internal class MacroObjectPool<T>
    {
        //并发安全集合，存放可用的实例
        public volatile static ConcurrentBag<T> _objects;
        //索引所有实例，以便最终释放
        private static List<T> _AllObject;
        private static Func<T> _objectGenerator;
        private static uint _instenceLimit;
        volatile static uint _instenceCount;


        static object objlock = new object();

        public MacroObjectPool(uint instenceLimit, Func<T> objectGenerator)
        {
            _instenceLimit = instenceLimit;
            _AllObject = new List<T>();
            if (objectGenerator == null) throw new ArgumentNullException("need a objectGenerator");
            _objects = new ConcurrentBag<T>();
            _objectGenerator = objectGenerator;
            //默认创建对象
            for (int i = 0; i < instenceLimit; i++)
            {
                PutObject(objectGenerator.Invoke());
            }
        }
        public static T GetObject()
        {
            T item;
            if (_objects.TryTake(out item)) return item;
            lock (objlock)
            {
                if (_instenceCount < _instenceLimit)
                {
                    _instenceCount++;
                    var ins = _objectGenerator();
                    Debug.WriteLine($"创建对象，总对象数量{_instenceCount}...");
                    return ins;
                }
            }
            while (true)
            {
                if (_objects.TryTake(out item)) return item;
                Debug.WriteLine("已经达到池配额，等待对象...");
                Thread.Sleep(500);
            }
        }

        public static void PutObject(T item)
        {
            _objects.Add(item);
        }

        public void Dispose()
        {
            foreach (var ins in _AllObject)
            {
                if (ins is IDisposable)
                {
                    (ins as IDisposable).Dispose();
                }
            }
        }
    }
}
