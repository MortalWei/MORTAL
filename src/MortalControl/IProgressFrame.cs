namespace Mortal
{
    /// <summary>
    /// 用户界面操作进度条窗体进度接口
    /// </summary>
    public interface IProgressFrame
    {
        /// <summary>
        /// 将进度条传递给用户界面,由用户操作
        /// </summary>
        /// <param name="backCall"></param>
        void LoadProgressHandle(IProgressCall backCall);
    }
}
