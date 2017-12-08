using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadingAndWritingInFileUsing3Threads
{
    class Program
    {
        static readonly StreamReader stream1 = File.OpenText(@"E:\C#\1.txt");
        static readonly StreamReader stream2 = File.OpenText(@"E:\C#\2.txt");
        static readonly StreamWriter stream3 = File.CreateText(@"E:\C#\3.txt");
        private static object block = new Object();


        static void Read(StreamReader stream)
        {
            lock (block)
            {
                string str = stream.ReadToEnd();
               Thread.Sleep(1000);
           
                stream3.WriteLine(str);
            }
        }
        //static void Read1()
        //{
        //    string str = stream1.ReadToEnd();
        //    Thread.Sleep(1000);
        //    lock (block)
        //    {
        //        stream3.WriteLine(str);
        //    }
        //}

        //static void Read2()
        //{
        //    string str = stream2.ReadToEnd();
        //    Thread.Sleep(2000);
        //    lock (block)
        //    {
        //        stream3.WriteLine(str);
        //    }
        //}
        static void Main(string[] args)
        {
            Thread[] threads ={new Thread(()=>Read(stream1)), new Thread(()=>Read(stream2))};
            threads[0].Start();
            threads[1].Start();
            threads[0].Join();
            threads[1].Join();
            stream3.Close();
        }
    }
}
