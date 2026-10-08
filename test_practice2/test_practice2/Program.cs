using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            A obj = new B();
            Console.WriteLine(obj.Msg());
            
            string s1 = "Hello";
            string s2 = s1;

            s2 += " World";

            Console.WriteLine(s2);*/
            string s1 = "Hello";
            string s2 = "Hel" + "lo";

            Console.WriteLine(s1 == s2);
            Console.WriteLine(object.ReferenceEquals(s1, s2));


        }
    }
}
