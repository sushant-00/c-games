using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack cars = new Stack();
            cars.Push("Bmw");
            cars.Push("Audi");
            cars.Push("XUV");
            cars.Push("XUV");
            

            Console.WriteLine("total Elements :" + cars.Count);
            /*
            cars.Pop();
            Console.WriteLine("second element : " + cars.Pop());




            // Console.WriteLine("second element : "+ cars.Pop());
            foreach (var ch in cars)
            {
                if (ch =="Audi")
                {
                    Console.WriteLine("second element : " + ch);

                }
            }
            */


        }
    }
}
