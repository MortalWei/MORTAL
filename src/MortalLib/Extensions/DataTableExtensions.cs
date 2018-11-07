using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Linq
{
    /// <summary>
    /// IEnumerable扩展
    /// </summary>
    public static class EnumerableExtend
    {
        /// <summary>
        /// ForEach扩展
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        /// <param name="express"></param>
        public static void ForEach(this System.Data.DataRowCollection args, Action<System.Data.DataRow> express)
        {
            foreach (System.Data.DataRow item in args)
            {
                express(item);
            }
        }
    }
}
