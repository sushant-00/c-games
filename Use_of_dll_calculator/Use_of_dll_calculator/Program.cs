using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculatorLibrary;

namespace Use_of_dll_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c_new = new Calculator();
            int a = c_new.Add(20, 40);
            Console.WriteLine(a);
        }
    }
}
