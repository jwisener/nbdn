using System;
using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetprep.infrastructure.extensions
{
    public static class Iteration
    {
        public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
        {
            foreach (var item in items) yield return item;
        }

        public static void each<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items) action(item);
        }

        public static IEnumerable<int> to(this int start, int end)
        {
            for (var i = start; i <= end; i++) yield return i;
        }
    }
}