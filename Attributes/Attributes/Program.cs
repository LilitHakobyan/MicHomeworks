using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [Color(Color = ConsoleColor.Blue)]
    class ColorClass
    {
        public override string ToString()
        {
            return "Hello World";
        }
    }
    class Program
    {
        static void ShowOnConsole(ColorClass c)
        {
            ColorAttribute ca =
                Attribute.GetCustomAttribute(c.GetType(),
                    typeof(ColorAttribute)) as ColorAttribute;

            ConsoleColor newColor;
            if (ca == null)
                newColor = Console.ForegroundColor;
            else
                newColor = ca.Color;

            ConsoleColor currentColor = Console.ForegroundColor;

            Console.ForegroundColor = newColor;
            Console.WriteLine(c);
            Console.ForegroundColor = currentColor;
        }
        static void Main(string[] args)
        {
            ShowOnConsole(new ColorClass());
        }
    }
}
