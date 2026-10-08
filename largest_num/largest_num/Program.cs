using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace largest_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 70;
            int b = 50;
            int c = 20;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is large");
                }
            }
            else if (b>c)
            {
                Console.WriteLine("b is larger");
            }
            else
            {
                Console.WriteLine("c is larher");
            }*/

            int year = 2024;
            if((year%4 == 0 )&& (year%100 != 0) || (year%400 == 0) )
            {
                Console.WriteLine("is leAP YEAR");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}
