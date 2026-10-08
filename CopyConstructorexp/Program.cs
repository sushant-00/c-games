using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address tempaddress = new Address("baner" , "pune");
            Address permenantadd = new Address(tempaddress);
            permenantadd.PrintAddress();
        }
    }
}
