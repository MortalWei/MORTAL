using Mortal.Interface;

namespace Mortal.Realization
{
    public abstract class Presenter<T> : IPresenter<T> where T : class, IView
    {
        public T View { get; }

        //这里的view作为引用，用于在presenter中获取View的实例
        protected Presenter(T view)
        {
            View = view;
        }
    }
}
