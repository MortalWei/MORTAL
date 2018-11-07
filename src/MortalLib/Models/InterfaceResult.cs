namespace Lenovo.XtraCommon
{
    public class InterfaceResult
    {
        /// <summary>
        /// 状态
        /// </summary>
        public EventStatus Status { get; set; }
        /// <summary>
        /// 结果集
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 提示信息
        /// </summary>
        public string Msg { get; set; }
    }

    public class InterfaceResult<T> : InterfaceResult
    {
        /// <summary>
        /// 结果集
        /// </summary>
        public new T Data { get; set; }
    }
}
