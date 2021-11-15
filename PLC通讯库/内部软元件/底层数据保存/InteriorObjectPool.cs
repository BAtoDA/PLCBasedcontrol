using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace PLC通讯库.内部软元件.底层数据保存
{
    /// <summary>
    /// 对象池
    /// 本类主要用于处理控件--语音播报对象池调用
    /// </summary>
    class InteriorObjectPool<T>:IDisposable
    {
        //并发安全集合，存放可用的实例
        public volatile static ConcurrentBag<T> _objects;
        //索引所有实例，以便最终释放
        private static List<T> _AllObject;
        private static Func<T> _objectGenerator;
        private static  uint _instenceLimit;
        volatile static uint _instenceCount;


        static object  objlock = new object();

        public InteriorObjectPool(uint instenceLimit, Func<T> objectGenerator)
        {
            _instenceLimit = instenceLimit;
            _AllObject = new List<T>();
            if (objectGenerator == null) throw new ArgumentNullException("need a objectGenerator");
            _objects = new ConcurrentBag<T>();
            _objectGenerator = objectGenerator;
            //默认创建对象
            for(int i=0;i<instenceLimit;i++)
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
