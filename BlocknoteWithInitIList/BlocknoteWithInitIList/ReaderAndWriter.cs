using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlocknoteWithInitIList
{
    static class ReaderAndWriter
    {
        public static void WriteInFile(this Blocknote blocknote,string filePath)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    foreach (Record record in blocknote)
                    {
                        sw.WriteLine(record.WritingStyle());
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public static  string WritingStyle(this Record rec)
        {
            return $"{rec.Name},{rec.Phone}";
        }

        public static void LoadRecordsFromFile(this Blocknote blocknote,string filePath)
        {
            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    while (!sr.EndOfStream)
                        blocknote.Add(sr.ReadLine().CreateRecord());
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private static Record CreateRecord(this string record)
        {
            string name = record.Substring(0, record.IndexOf(","));
            string phone = record.Substring(record.LastIndexOf(",")+1);
            return new Record(name, phone);
        }
    }
}
