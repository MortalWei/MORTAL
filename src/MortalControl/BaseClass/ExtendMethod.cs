using System;
using System.ComponentModel;

namespace Mortal.Parts
{
    /// <summary>
    /// Action扩展
    /// </summary>
    internal static class ExtendMethod
    {
        /// <summary>
        /// 获取Method描述
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        internal static string MethodDescription(this Action method)
        {
            var _Attr = method.Method.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (_Attr.Length == 0) return method.Method.Name;
            return ((DescriptionAttribute)_Attr[0]).Description;
        }
    }
}
