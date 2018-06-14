using System;
using System.Threading;

namespace myThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Thread principal iniciada");

            Thread t1 = new Thread(new ThreadStart(run));
            t1.Name = "Secundária - ";
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread atual - " + Thread.CurrentThread.Name + i);
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("Thread Principal terminada");
            Console.Read();
        }

        public static void run()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread Atual -" + Thread.CurrentThread.Name + i);

                Thread.Sleep(1000);
            }
        }
    }
}
