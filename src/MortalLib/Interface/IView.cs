namespace Mortal.Interface
{
    public interface IView { }

    public interface IView<T> : IView where T : class
    {
        /// <summary>
        /// 默认实体,一般为患者信息
        /// </summary>
        T Model { get; set; }
    }
}
