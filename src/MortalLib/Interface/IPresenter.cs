namespace Mortal.Interface
{
    public interface IPresenter { }

    public interface IPresenter<T> : IPresenter where T : class, IView
    {
        T View { get; }
    }
}
