using Mortal.Interface;

namespace Mortal.Realization
{
    /// <summary>
    /// MVP 模式Presenter基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Presenter<T> : IPresenter<T> where T : class, IView
    {
        /// <summary>
        /// 关联的视图实例
        /// </summary>
        public T View { get; }

        /// <summary>
        /// 默认构造
        /// 获取视图实例
        /// </summary>
        /// <param name="view"></param>
        protected Presenter(T view)
        {
            View = view;
        }
    }
}
