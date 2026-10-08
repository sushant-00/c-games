using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floattype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            float value = 12.455556666631f;
            Console.WriteLine(value);

            double value_a = 12.3444444444444444444;
            Console.WriteLine(value_a);

            decimal value_b = 12.33333333333333333333333333333333333333333333333333333333333333333333m;
            Console.WriteLine(value_b);
            char ch = 'a';
            Console.WriteLine(ch);*/
            Price p1 = new Price();
            Console.WriteLine(p1.Get_price());
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
        }
    }
}
