using System;

namespace Lenovo.XtraCommon
{
    /// <summary>
    /// 包含事件数据的基类。
    /// </summary>
    public class MortalEventArgs : EventArgs
    {
        /// <summary>
        /// 状态
        /// </summary>
        public EventStatus Status { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public object Result { get; set; }
        /// <summary>
        /// 提示
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 待处理数据
        /// </summary>
        public string Args { get; set; }
    }

    /// <summary>
    /// 包含事件数据的基类
    /// </summary>
    /// <typeparam name="T">结果</typeparam>
    public class MortalEventArgs<T> : EventArgs where T : class
    {
        /// <summary>
        /// 状态
        /// </summary>
        public EventStatus Status { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public T Result { get; set; }
        /// <summary>
        /// 提示
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 待处理数据
        /// </summary>
        public string Args { get; set; }
    }

    /// <summary>
    /// 包含事件数据的基类
    /// </summary>
    /// <typeparam name="T">待处理数据</typeparam>
    /// <typeparam name="TReturn">结果</typeparam>
    public class MortalEventArgs<T, TReturn> : EventArgs where T : class
    {
        /// <summary>
        /// 状态
        /// </summary>
        public EventStatus Status { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public TReturn Result { get; set; }
        /// <summary>
        /// 提示
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 待处理数据
        /// </summary>
        public T Args { get; set; }
    }
}
