namespace MortalControl
{
    /// <summary>
    /// 用户窗体操作进度窗体回调函数
    /// </summary>
    public interface IProgressCall
    {
        /// <summary>
        /// 向前推进
        /// </summary>
        void PerformStep();

        /// <summary>
        /// 向前推进
        /// </summary>
        /// <param name="title">提示文本</param>
        void PerformStep(string title);
    }
}
