﻿using System.Collections.Generic;

namespace System.Linq
{
    /// <summary>
    /// IEnumerable扩展
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// ForEach扩展
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        /// <param name="express"></param>
        public static void ForEach<T>(this IEnumerable<T> args, Action<T> express)
        {
            foreach (var item in args)
            {
                express(item);
            }
        }
    }
}
