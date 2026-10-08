using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            string day = Console.ReadLine();

            switch(day){
                case "monday":
                    Console.WriteLine("Monday it is");
                    break;
                case "Tuesday":
                    Console.WriteLine("it is tuesday");
                    break;
                default:
                    Console.WriteLine("plz enter valid operator");
                    break;
            }



        }
    }
}
