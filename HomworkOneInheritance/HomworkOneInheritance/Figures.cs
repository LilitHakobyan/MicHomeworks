using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomworkOneInheritance
{
    public class Figures
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Figures(double height, double width)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine("Figures Drow");
        }
    }

    public class Rectangular : Figures
    {
        public Rectangular(double height, double width) : base(height, width)
        {

        }
        public new void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            base.Draw();

        }
        
       
    }
    public class Triangular : Figures
    {
        public Triangular(double height, double width) : base(height, width)
        {

        }
        public new void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (double  j = Width-i-1; j <Width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
    public class Quadrate : Figures
    {
        public Quadrate(double size) : base(size, size)
        {

        }
        public new void Draw()
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
