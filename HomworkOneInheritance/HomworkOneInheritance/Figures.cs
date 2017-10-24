using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomworkOneInheritance
{
    class Figures
    {  public double Width  {get; set;}
       public double Height { get; set;}

        public Figures(double height, double width)
        {
            Width = width;
            Height = height;
        }
    }

    class Rectangular:Figures
    {
        public Rectangular(double height, double width) : base(height, width)
        {
            
        }
        public void Drow()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
        }
    }
    class Triangular : Figures
    {
        public Triangular(double height, double width) : base(height, width)
        {

        }
        public void Drow()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j <i+1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
        }
    }
    class Quadrate : Figures
    {
        public Quadrate(double size) : base(size, size)
        {

        }
        public void Drow()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
