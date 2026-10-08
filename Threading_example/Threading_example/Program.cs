using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintNumber);
            Thread t2 = new Thread(PrintValues);
            thread.Start();
            thread.Join();
            t2.Start();
            

        }

        public static void PrintNumber()
        {
            Console.WriteLine("string print number method" + DateTime.Now);
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);

            }
            Console.WriteLine("end of program :" + DateTime.Now);


        }
        public static void PrintValues()
        {
            Console.WriteLine("string print number method" + DateTime.Now);
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("number");

            }
            Console.WriteLine("end of program :" + DateTime.Now);


        }
    }
}
