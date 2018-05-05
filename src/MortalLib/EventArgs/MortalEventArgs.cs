using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mortal
{
    /// <summary>
    /// 包含事件数据的基类。
    /// </summary>
    public class MortalEventArgs : EventArgs
    {
        public EventStatus Status { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
    }

    /// <summary>
    /// 包含事件数据的基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MortalEventArgs<T> : EventArgs where T : class
    {
        public EventStatus Status { get; set; }
        public T Result { get; set; }
        public string Message { get; set; }
    }
}
