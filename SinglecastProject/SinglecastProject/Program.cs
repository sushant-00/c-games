
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SinglecastProject
{
    internal class Program
    {
        public delegate void MyDelegate(String msg);
        static void Main(string[] args)
        {
            MyDelegate mydelegate = pPint; 
           
            mydelegate += show;
            mydelegate("hello sir i am present" );
            mydelegate("what hapens here");
            


        }
        public static void pPint(string msg)
        {
            Console.WriteLine(msg);


        }
        public static void show(string msg)
        {
            Console.WriteLine(msg);

        }


    }
}

