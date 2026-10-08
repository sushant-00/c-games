using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Pen
    {
        public void Refill()
        {
            Console.WriteLine("refilled ");
        }
        public void Ink()
        {
            Console.WriteLine("ink");


        }
        public string Paper { get; set; }
    }
}
