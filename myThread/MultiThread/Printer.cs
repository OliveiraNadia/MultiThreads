using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThread
{
    class Printer
    {
        //public void PrintNumbers() //Utilizando Lock
        //{
        //    lock (this)
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Thread.Sleep(100);
        //            Console.WriteLine(i + ",");
        //        }
        //        Console.WriteLine();

        //    }

        //}
        public void PrintNumbers() //Utilizando monitor type 
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Monitor.Exit(this);
            }
            

        }
    }
}
