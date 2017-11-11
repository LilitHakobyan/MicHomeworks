using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        public static char AcssesToPrivateMEthod()
        {
            Type t = typeof(string);
            string s = "hello";

            PropertyInfo mi = null;
            foreach (PropertyInfo item in t.GetProperties(BindingFlags.NonPublic |
                                                          BindingFlags.Instance))
            {
                if (item.Name.Equals("FirstChar",
                    StringComparison.InvariantCultureIgnoreCase))
                    mi = item;
            }

            return (char)mi.GetValue(s);
        }
        static void Main(string[] args)
        {
            Type t = typeof(string);
            string s = "hello";

            MethodInfo mi = null;

            foreach (MethodInfo item in t.GetMethods())
            {
                if (item.Name == "ToUpper" && !item.GetParameters().Any())
                {
                    mi = item;
                    break;
                }
            }
            if (mi == null)
            {
                Console.WriteLine("Not found");
                return;
            }
            Console.WriteLine(AcssesToPrivateMEthod());
            Console.WriteLine(mi.Invoke(s, null));
        }
    }
}
