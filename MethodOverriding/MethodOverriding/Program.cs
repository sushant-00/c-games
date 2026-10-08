using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*pink p1 = new pink();
            //p1.Prints();
            Printer p1 = new pink();
            p1.Prints();
            */
            //Printer p11 =  new Printer();
            //pink p2 = (pink)p11;
            pink p1 = new pink();
            p1.Prints();
        }
    }
}
