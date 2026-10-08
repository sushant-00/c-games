using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    public abstract class Printer
    {
        public abstract void ColorPrint();
        public void Get_paper()
        {
            Console.WriteLine("get the papper");
        }
        

        //public abstract void 
    }
    public  class Laser_Printer :Printer
    {
        public override void ColorPrint()
        {
            Console.WriteLine("color is laser print");
        }
        public void laser_Print()
        {
            Console.WriteLine("laser  print");
        }

        //public abstract void 
    }
    public class Black_p : Printer
    {
        public override void ColorPrint()
        {
            Console.WriteLine("color is blackprint");
        }
        public void Black_Print()
        {
            Console.WriteLine("black laser  is  print");
        }

        //public abstract void 
    }
}
