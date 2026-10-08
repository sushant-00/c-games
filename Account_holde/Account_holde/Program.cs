using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Account_holde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyPin p1 = new MyPin();
            Credit c1 = new Credit();
            c1.credit1("200");
            c1.show_debit();
            Credit c2 = new Credit();
            c1.credit1("2003");

            c2.show_debit2();



        }
    }
}
