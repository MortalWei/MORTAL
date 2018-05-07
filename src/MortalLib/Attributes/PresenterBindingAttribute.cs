using System;

namespace Mortal.Attributes
{
    /// <summary>
    /// MVP模式 用户界面设置Presenter
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class PresenterBindingAttribute : Attribute
    {
        /// <summary>
        /// 父级Presenter
        /// </summary>
        public Type PresenterType { get; private set; }

        /// <summary>
        /// 子级Presenter
        /// </summary>
        public Type ViewType { get; set; }

        /// <summary>
        /// 默认构造
        /// 设置Presenter实例
        /// </summary>
        /// <param name="presenterType"></param>
        public PresenterBindingAttribute(Type presenterType)
        {
            PresenterType = presenterType;
            ViewType = null;
        }
    }
}
