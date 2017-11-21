using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknoteWithInitIList
{
    class Program
    {
        
        public static bool FindByName(Record rec, string name)
        {
            if (rec.Name == name)
                return true;
            return false;
        }

        public static bool FindByPhone(Record rec, string phon)
        {
            if (rec.Phone == phon)
                return true;
            return false;
        }
        static bool PhonStartsWith(Record rec,string op) { return rec.Phone.StartsWith(op); }
        static bool NameStartsWithG(Record rec) { return rec.Name.StartsWith("G"); }

        static void Main(string[] args)
        {
            Blocknote bloknote = new Blocknote();
            bloknote.Add(new Record("Amy", "75585555887"));
            bloknote.Add(new Record("Kurt", "75495620557"));
            bloknote.Add(new Record("Janis", "78159529822"));
            bloknote.Add(new Record("Armin", "098000000"));
            bloknote.Add(new Record("Adam", "87952879218"));
            bloknote.Add(new Record("Semy", "98151158754"));
            bloknote.Add(new Record("Gary", "75495620557"));

            string filePath = @"E:\Blocknote\block.txt";

           bloknote.WriteInFile(filePath);
          // bloknote.LoadRecordsFromFile(filePath);
            //bloknote.ShowOnConsole();

            //Console.WriteLine(bloknote.Contains(new Record("Semy", "98151158754")));
            //Console.WriteLine("Index OF");
            //Console.WriteLine(bloknote.IndexOf(new Record("Semy", "98151158754")));
            //Console.WriteLine("Remove item");
            //bloknote.Remove(new Record("Armen", "098000000"));
            //bloknote.ShowOnConsole();
            //Console.WriteLine("insert item");
            //bloknote.Insert(3,new Record("InsertItem", "98151158754"));
            //bloknote.ShowOnConsole();
            //bloknote.Remove(new Record("InsertItem", "98151158754"));
            //bloknote.ShowOnConsole();
            //bloknote.ReturnRecordsByCondition(NameStartsWithG).ShowBlock(Console.WriteLine);
            //bloknote.FindRecord(FindByPhone, "098000000").ShowBlock(Console.WriteLine);
            //bloknote.FindRecord(PhonStartsWith, "055").ShowBlock(Console.WriteLine);
            //bloknote.FindRecord(FindByName, "Hakob").ShowBlock(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
