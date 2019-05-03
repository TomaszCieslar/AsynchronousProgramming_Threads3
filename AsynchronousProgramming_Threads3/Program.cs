using System;
using System.Threading;

namespace AsynchronousProgramming_Threads3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            t.Start();

          
                Console.WriteLine("Press any key to exit... ");
            Console.ReadLine();

            stopped = true;

            t.Join();

           

        }


        public static void ThreadMethod(object temp)
        {
            for (int i = 0; i < (int)temp; i++)
            {
                Console.WriteLine($"Thread {i}");
                Thread.Sleep(0);
            }

        }
    }
}
