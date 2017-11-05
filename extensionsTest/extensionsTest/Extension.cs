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
    }
}
