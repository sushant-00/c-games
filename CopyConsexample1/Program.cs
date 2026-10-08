using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConsexample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            String name = Console.ReadLine();
            Person1 p1 = new Person1(id, name);
            Person1 p2 = new Person1(p1);
            p2.Display1();
        }
    }
}
