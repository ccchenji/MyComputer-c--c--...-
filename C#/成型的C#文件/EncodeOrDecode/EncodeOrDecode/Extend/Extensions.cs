using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    static class Extensions
    {
        /// <summary>
        /// IEnumerable的扩展方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequence"></param>
        /// <param name="action">无参委托</param>
        public static void ForAll<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence)
            {
                action(item);
            }
        }
    }
}
