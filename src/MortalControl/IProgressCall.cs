namespace Mortal
{
    /// <summary>
    /// 用户窗体操作进度窗体回调函数
    /// </summary>
    public interface IProgressCall
    {
        /// <summary>
        /// 向前推进
        /// </summary>
        /// <param name="title">提示文本</param>
        void PerformStep(string title);

        /// <summary>
        /// 完成
        /// </summary>
        void Finish();

        /// <summary>
        /// 设置进度条默认最大值
        /// </summary>
        /// <param name="title">默认标题</param>
        /// <param name="total">总进度数</param>
        void SetTotal(string title, int total);
    }
}
