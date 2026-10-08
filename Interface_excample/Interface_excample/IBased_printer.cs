using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_excample
{
    public  interface IBased_printer
    {
        void print();
        void ColorPrint();
        
    }

    public class Printer : IBased_printer
    {
        public void print()
        {
            Console.WriteLine("printer is printed");
        }
        public void ColorPrint()
        {
            Console.WriteLine("color is white");
        }
    }
}
