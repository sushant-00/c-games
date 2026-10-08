using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desison_making
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age >= 18)
            {
                Console.WriteLine("you are an adult");
            }
            else
            {
                Console.WriteLine("you are not eligiable");
            }*/
            /*
            Console.WriteLine("Enter num :");
            int number = int.Parse(Console.ReadLine());
            if (number%2 == 0)
            {
                Console.WriteLine("odd number");
            }
            else
            {
                Console.WriteLine("Even number");
            }*/
            //Console.WriteLine("Enter your marks");
            /*int Stu_marks = int.Parse(Console.ReadLine());
            if(Stu_marks >=70)
            {
                Console.WriteLine("distinction");
            }
            else if(Stu_marks<70 && Stu_marks >= 60 )
            {
                Console.WriteLine("Fisrtclass");
            }
            else if (Stu_marks < 60 && Stu_marks >= 50)
            {
                Console.WriteLine("season");
            }
            else if(Stu_marks < 50 && Stu_marks >= 35)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail");
            }*/
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("sun");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }

        }
    }
}
