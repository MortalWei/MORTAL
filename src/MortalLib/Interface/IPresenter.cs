namespace Lenovo.XtraCommon
{
    /// <summary>
    /// MVP模式 Presenter接口基类
    /// </summary>
    public interface IPresenter { }

    /// <summary>
    /// MVP模式 Presenter接口基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPresenter<T> : IPresenter where T : class, IView
    {
        /// <summary>
        /// 关联的视图实例
        /// </summary>
        T View { get; }
    }
}
