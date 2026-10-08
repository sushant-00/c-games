using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(null);
            int nu2 = int.Parse("23");
            string s1 = "23";
            //int s2 = (int) s1;

            //int num2 = "23";
            //int a = Convert.ToString();
            //string s1 = "";
            //int a = SortedSet;
            double ab = 12.78;
            int a = (int)ab;
            //Console.WriteLine(a);
            string name = null;
            Console.WriteLine(name.ToString());
            Console.WriteLine(Convert.ToString(a));
            //string s2 = Convert.ToString(name);
            string s2 = name.ToString();
            Console.WriteLine(s2);
            
        }
        public int cast1()
        {
            object str1 = "123";
            
            return (int)str1;
        }
    }
}
