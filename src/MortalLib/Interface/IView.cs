namespace Mortal.Interface
{
    /// <summary>
    /// MVP View基类
    /// </summary>
    public interface IView { }

    /// <summary>
    /// MVP View基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IView<T> : IView where T : class, new()
    {
        /// <summary>
        /// 默认实体
        /// </summary>
        T Model { get; set; }
    }
}
