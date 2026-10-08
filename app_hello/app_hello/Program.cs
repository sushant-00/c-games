using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace app_hello
{
    internal class Program

    {
        public static void Type(string msg , int delayTime)
        {
            foreach(char c in msg)
            {
                Console.Write(c);
                Thread.Sleep(delayTime);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Type("hello X", 50);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Type("you look cute today ", 50);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Type("just kidding okay (now don't blush)" ,150);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Type("you  always look cute (specially when you smile )!", 200);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Type("now dont blush and blame me for it", 20);
            Console.ResetColor();



            Console.ReadKey();



        }
    }
}
