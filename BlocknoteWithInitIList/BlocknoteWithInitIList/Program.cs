using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknoteWithInitIList
{
    class Program
    {
        static void Main(string[] args)
        {
            Blocknote bloknote = new Blocknote();
            bloknote.Add(new Record("John", "055060408"));
            bloknote.Add(new Record("Hakob", "09585891"));
            bloknote.Add(new Record("Armen", "098000000"));
            bloknote.Add(new Record("Armen", "098000000"));
            bloknote.Add(new Record("Adam", "87952879218"));
            bloknote.Add(new Record("Semy", "98151158754"));
            bloknote.Add(new Record("Gary", "75495620557"));
            bloknote.ShowOnConsole();

            Console.WriteLine(bloknote.Contains(new Record("Semy", "98151158754")));
            Console.WriteLine("Index OF");
            Console.WriteLine(bloknote.IndexOf(new Record("Semy", "98151158754")));
            Console.WriteLine("Remove item");
            bloknote.Remove(new Record("Armen", "098000000"));
            bloknote.ShowOnConsole();
            Console.WriteLine("insert item");
            bloknote.Insert(3,new Record("InsertItem", "98151158754"));
            bloknote.ShowOnConsole();
            bloknote.Remove(new Record("InsertItem", "98151158754"));
            bloknote.ShowOnConsole();
            Console.ReadKey();
        }
    }
}
