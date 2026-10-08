using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDelegate
{
    internal class Program
    {
        public delegate void MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            MyDelegate calculator = ADD;
            calculator += Sub;
            calculator += Multiply;
            calculator += Divide;
            calculator(2, 3);
        }

        public static void ADD(int a, int b)
        {
            Console.WriteLine("addition is :"+ (a+b));

        }

        public static void Sub(int a,int b)
        {
            Console.WriteLine("sub is :"+ (a-b));

        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("multiply is :" + (a *b));

        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine("divide is :" + (a /b));

        }


    }
}
