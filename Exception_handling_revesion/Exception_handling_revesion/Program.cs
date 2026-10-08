using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_revesion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int result = a / b;

            }
            catch(DivideByZeroException exp)
            {
                Console.WriteLine("cannot divide by zero");






            }
            catch(FormatException fexp)
            {
                Console.WriteLine("cannot enter string value ");
            }
            catch(Exception ep)
            {
                Console.WriteLine("generic exception");

            }



        }
    }
}
