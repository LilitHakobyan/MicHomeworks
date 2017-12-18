using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProducesConsumerThreads
{
    class Program
    {
        static object objToLock = new object();

        static Queue<int> dataQueue = new Queue<int>();
        static Random random = new Random();

        static StreamWriter sw;

        static Thread[] producerThreads;
        static Thread[] consumerThreads;

        /// <summary>
        /// Flag for detecting exit mode
        /// </summary>
        static bool isExiting = false;

        static void ProducerCode()
        {
            do
            {
                // if program is closing, stop production
                if (isExiting)
                    break;

                int timeToSleep = random.Next(0, 101); // 101 because the max value is exclusive
                Thread.Sleep(timeToSleep);

                int numberToInsert = random.Next(1, 101);

                lock (objToLock)
                {
                    dataQueue.Enqueue(numberToInsert);
                    Monitor.PulseAll(objToLock); // a value Inserted to queue, so it's count > 0 and we can wake up all Consumers

                    if (dataQueue.Count >= 100)
                        while (dataQueue.Count > 80)
                            Monitor.Wait(objToLock);  // The data limit is achived, so wait (block) until a pulse got and queue.count <= 80
                }

            } while (true);
        }

        static void ConsumerCode()
        {
            do
            {
                int timeToSleep = random.Next(0, 101);
                Thread.Sleep(timeToSleep);

                lock (objToLock)
                {
                    if (dataQueue.Count == 0 && isExiting) // if program is closing and there is no data in queue,  stop consuming
                    {
                        Monitor.PulseAll(objToLock); // unblock any blocked threads
                        break;
                    }

                    while (dataQueue.Count == 0)
                        Monitor.Wait(objToLock); // There is no value in queue, so wait before a producer inserts new number

                    int dequeuedNumber = dataQueue.Dequeue();
                    sw.Write(String.Format("{0},", dequeuedNumber)); // send dequeued number to file;

                    if (dataQueue.Count <= 80)
                        Monitor.PulseAll(objToLock); // Ask all waiting Producers, that thay can continue produce numbers!
                }

            } while (true);
        }


        /// <summary>
        /// Shows amount of data in queue each second
        /// </summary>
        static void DataQueueCountPresenter()
        {
            do
            {
                Thread.Sleep(1000);
                Console.WriteLine(dataQueue.Count);

            } while (true);
        }

        static void Main(string[] args)
        {
            sw = new StreamWriter("data.txt");

            Console.CancelKeyPress += Console_CancelKeyPress; // I am expecting, that you are going to use ctrl+C to close the program.

            int M = 0;
            int N = 0;

            #region get start data part
            bool correctData = true;
            do
            {
                Console.Write("Producer Count N = ");
                correctData = Int32.TryParse(Console.ReadLine(), out N);

                Console.Write("Consumers Count M = ");
                correctData &= Int32.TryParse(Console.ReadLine(), out M);

                if (!correctData)
                    Console.WriteLine("Please, enter correct data");

            } while (!correctData);
            #endregion

            producerThreads = new Thread[N];
            consumerThreads = new Thread[M];

            //Start all threads
            for (int i = 0; i < N; i++)
                (producerThreads[i] = new Thread(ProducerCode)).Start();

            for (int i = 0; i < M; i++)
                (consumerThreads[i] = new Thread(ConsumerCode)).Start();

            Thread showCountThread = new Thread(DataQueueCountPresenter);
            showCountThread.Start();

            consumerThreads.ToList().ForEach(t => t.Join());
            producerThreads.ToList().ForEach(t => t.Join());

            showCountThread.Abort(); // thanks to thread to show us useful information, but we don't need him anymore
            sw.Close(); // Close file

            Console.WriteLine("All data saved, press any key to exit");
            Console.ReadKey();
        }


        /// <summary>
        /// This handler will be called when you press ctrl + C or other cancel kay combination.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("Exiting program started");

            // Do not exit just now. We have some work to do. 
            // Just ask threads to finish their work, after which the main thread will close the file and exit program
            e.Cancel = true; 

            isExiting = true; // flag all threads to start finishing their job
        }
    }
}
