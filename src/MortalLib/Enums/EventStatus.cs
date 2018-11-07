namespace Lenovo.XtraCommon
{
    /// <summary>
    /// 事件处理状态
    /// </summary>
    public enum EventStatus
    {
        /// <summary>
        /// 等待=0
        /// </summary>
        Waiting = 0,
        /// <summary>
        /// 成功=1
        /// </summary>
        Success = 1,
        /// <summary>
        /// 失败=2
        /// </summary>
        Fail = 2,
        /// <summary>
        /// 警告=3
        /// </summary>
        Warning = 3,
        /// <summary>
        /// 取消
        /// </summary>
        Cancel = 4,
        /// <summary>
        /// 无效
        /// </summary>
        Invalid = 5
    }
}
