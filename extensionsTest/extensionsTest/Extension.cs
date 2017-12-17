using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionsTest
{
   static class Extension
    {
        public static void ShowOnConsole(this string s)
        {
            
            Console.WriteLine(s);
        }

        public static bool IsSameType(this string type, string name)
        {
            return type.GetType() == name.GetType();
        }
    }
}
