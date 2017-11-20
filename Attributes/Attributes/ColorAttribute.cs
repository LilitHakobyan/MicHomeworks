using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class ColorAttribute:Attribute
    {
        public ConsoleColor Color { get; set; }

        public ColorAttribute()
        {

        }

        public ColorAttribute(ConsoleColor color)
        {
            Color = color;
        }
    }
}
