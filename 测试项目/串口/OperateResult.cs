using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace HD烟灶联动项目.串口
{
    /// <summary>
    /// 串口结果返回
    /// </summary>
    /// <typeparam name="T">泛型T</typeparam>
    public class OperateResult<T>
    {
        public T Result { get; set; }

        public bool isResult { get;set; }

        public OperateResult() { }
        public OperateResult(bool Result) => isResult = Result;
    }
}
