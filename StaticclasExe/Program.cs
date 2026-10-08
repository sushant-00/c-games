using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticclasExe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("emp name :" + Employees.GetName());
            //Console.WriteLine("emp salary " + Employees.GatSalary());
            Console.WriteLine(Maths.add(22, 1));
            Console.WriteLine(Maths.subs(20, 10));
            Console.WriteLine(Maths.multiply(22, 1));

        }
    }
}
