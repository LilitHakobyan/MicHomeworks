using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    class Program
    {
        static void F()
        {
            try
            {
                int x = 0;
                File.Open("ahah", FileMode.Open);
                int y = 10 / x;


                Console.WriteLine("End of try");
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("divaided By zero");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown Exception");
            }
            finally
            {
                
            }
            Console.WriteLine("after catch");
        }

        static void SetAge(int x)
        {
            if(x< 0)
                throw  new ArgumentException("age < 0");
        }
        static void F1()
        {
            throw new FileNotFoundException();
        }
        static void Main(string[] args)
        {
            F1();
            Console.WriteLine("after F");
        }
    }
}
