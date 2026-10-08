using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {    /*
            Employee emp = new Employee();
            emp.Get_Emp_name();
            Console.WriteLine(emp.Get_name_emp());*/
            Calculator c1 = new Calculator();

            Console.WriteLine(c1.add(2, 3));
            Console.WriteLine(c1.substract(2, 3));
            Console.WriteLine(c1.multiplication(2, 3));
            Console.WriteLine(c1.substract(2, 3));
            
        }
    }
}
