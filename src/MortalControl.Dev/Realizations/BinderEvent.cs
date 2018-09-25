using Lenovo.XtraEditors.IEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lenovo.XtraEditors.Realizations
{
    public class BinderEvent
    {
        public static List<T> GetEvents<T>() where T : IGridColumnEventArgs, ITreeColumnEventArgs
        {
            var interfaceImplements2 = System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                .Where(item => item.GetInterfaces().Contains(typeof(T)) && item.Namespace == "MortalDemo.HYGrid").ToList();
        }
    }
}
