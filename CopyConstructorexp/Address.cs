using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorexp
{
    public class Address
    {
        public string address1;
        public string address2;

        public Address(String address1 , String address2)
        {
            this.address1 = address1;
            this.address2 = address2;
        }

        public Address(Address address)
        {
            address1 = address.address1;
            address2 = address.address2;

        }

        public void PrintAddress()
        {
            Console.WriteLine("my address1 is " + address1);
            Console.WriteLine("my address2 is " + address2);
        }

        public void ShowAdress()
        {
            PrintAddress();
        }
    }
}
