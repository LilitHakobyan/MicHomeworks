using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks1 = new Task[3]
            {
                new Task(() => Console.WriteLine("First Task")),
                new Task(() => Console.WriteLine("Second Task")),
                new Task(() => Console.WriteLine("Third Task"))
            };
            // задача продолжения
            Task task
                = tasks1[2].ContinueWith((task1 => Console.WriteLine("Four Task")));
            foreach (var t in tasks1)
                t.Start();
            //Task.WaitAll(tasks1); // ожидаем завершения задач 
           // Task.WaitAny(tasks1);

            Task[] tasks2 = new Task[3];
            int j = 1;
            for (int i = 0; i < tasks2.Length; i++)
                tasks2[i] = Task.Factory.StartNew(() => Console.WriteLine($"Task {j++}"));

            Console.WriteLine("Завершение метода Main");

            Console.ReadLine();
        }
    }
}
