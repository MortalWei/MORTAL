using System;

namespace Mortal.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class PresenterBindingAttribute : Attribute
    {
        public Type PresenterType { get; private set; }

        public Type ViewType { get; set; }

        public PresenterBindingAttribute(Type presenterType)
        {
            PresenterType = presenterType;
            ViewType = null;
        }
    }
}
