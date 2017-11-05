using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blocknote
{
    class Program
    {
        static void Main(string[] args)
        {
            Bloknote bloknote=new Bloknote();
            bloknote.Add(new Record("John", "055060408"));
            bloknote.Add(new Record("Hakob", "09585891"));
            bloknote.Add(new Record("Armen", "098000000"));
            bloknote.Add(new Record("Armen", "098000000"));
            bloknote.Add(new Record("Adam", "87952879218"));
            bloknote.Add(new Record("Semy", "98151158754"));
            bloknote.Add(new Record("Gary", "75495620557"));
            bloknote.ShowOnConsole();
            Console.WriteLine(bloknote.Contain(new Record("Semy", "98151158754")));
            Console.WriteLine(bloknote.InfexOf(new Record("Semy", "98151158754")));
            bloknote.Remove(new Record("Armen", "098000000"));
            bloknote.ShowOnConsole();
            bloknote.Remove(new Record("Semy", "98151158754"));
            bloknote.ShowOnConsole();
            Console.ReadKey();
        }
    }
}
