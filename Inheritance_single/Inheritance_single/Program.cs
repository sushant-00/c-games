using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person1 p1 = new Person1
            {
                Name = "joe don",
                age = 20,
                Addharcardnumber = "2223311"

            };

            p1.Displayinfo();
            p1.DisplayAd();


        }
    }
}
