using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_single
{
    public class Addharcard
    {
        public Addharcard()
        {
            Console.WriteLine("addharcard called ");
        }
        public string Addharcardnumber { get; set; }
        public void DisplayAd()
        {
            Console.WriteLine($"addharcard_number :{Addharcardnumber}");
        }
    }
}
