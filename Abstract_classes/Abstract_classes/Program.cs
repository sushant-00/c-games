using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printer p1 = new Printer();
            Laser_Printer l1 = new Laser_Printer();
            l1.laser_Print();
            l1.ColorPrint();
            l1.Get_paper();
            Black_p bp = new Black_p();
            bp.Black_Print();
        }
    }
}
