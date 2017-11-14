using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayItemsTest
{
    static class Extensions
    {
        public static IEnumerable<T> GetElementsByCondition<T>(this IEnumerable<T> array,
            ConditionDelegate<T> predicate)
        {
            foreach (T item in array)
            {
                if (predicate(item))
                    yield return item;
            }
        }

        public static void MakeAction<T>(this IEnumerable<T> array,
            Action<T> action)
        {
            foreach (T item in array)
            {
                action(item);
            }
        }
    }
}