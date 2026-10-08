using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public  class Printer
    {
        public virtual void Prints()
        {
            Console.WriteLine("prints");
        }

    }
    public class black:Printer
    {
        public override void Prints()
        {
            Console.WriteLine("prints black");
        }

    }
    public class pink : Printer
    {
        public  void Prints()
        {
            Console.WriteLine("prints pinks ");
        }

    }
}
