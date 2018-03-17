using System;
using System.Collections.Generic;

namespace DelTest
{
    static class Extention
    {
        public static IEnumerable<double> AnyAction(this IEnumerable<int> array, Func<int, double> anyFunc)
        {
            foreach (int item in array)
            {
                
                yield return anyFunc(item);
            }
        }

        public static void Display(this IEnumerable<double> array, Action<double> action)
        {
            foreach (double item in array)
            {
                action(item);
            }
        }
    }
}

