using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_holde
{
    partial class Credit
    {
        public void Credit1()
        {
            Console.WriteLine("hell credit 1");
        }
        public void show_debit()
        {
            Console.WriteLine("ammount is 1000");

        }
    }
    partial class Credit
    {
        public void credit1(string s)
        {
            Console.WriteLine("Credit amount is " + s);
        }
        public void show_debit2()
        {
            Console.WriteLine("your ammount is 500");
        }
    }
}
