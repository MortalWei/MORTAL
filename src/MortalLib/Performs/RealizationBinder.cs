using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortalLib.Performs
{
    /// <summary>
    /// 接口类的实现绑定
    /// </summary>
    public class RealizationBinder
    {
        /// <summary>
        /// 获取接口的实现类
        /// </summary>
        /// <typeparam name="T">接口类</typeparam>
        /// <param name="nameSpace">指定命名空间</param>
        /// <returns></returns>
        public static List<T> GetRealization<T>(string nameSpace = "")
        {
            if (typeof(T).IsInterface) return null;
            if (string.IsNullOrEmpty(nameSpace))
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                    .Where(item => item.GetInterfaces().Contains(typeof(T)))
                    .Select(type => (T)Activator.CreateInstance(type)).ToList();
            }
            else
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                    .Where(item => item.GetInterfaces().Contains(typeof(T)) && item.Namespace.Equals(nameSpace))
                    .Select(type => (T)Activator.CreateInstance(type)).ToList();
            }
        }
    }
}
