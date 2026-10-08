using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace hello_sushant
{
    internal class Program

    {

        static void Type(String msg , int deylmsg = 60)
        {
            foreach(char c in msg)
            {
                Console.Write(c);
                Thread.Sleep(deylmsg);
            }
            Console.WriteLine();
        }
        

        
        static void Main(string[] args)
        {
            //Console.WriteLine("hello");
            //Console.Title = "sushant";
            Console.ForegroundColor = ConsoleColor.Red;
            Type("Hi x !" , 50);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Type("you look cute today" , 50);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Type("just kidding !", 150);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Type("you always look cute", 200);
            Console.ResetColor();

            Console.WriteLine("Wann grab coffe or snack this evening ?? [Y/N]");
            String choice = Console.ReadLine().ToUpper();
            if(choice == "Y")
            {
                Console.WriteLine("Cool");
                Console.WriteLine("how about 6.30 , will this work for you [Y?N]");
                String choice_time = (Console.ReadLine().ToUpper());
                if(choice_time == "Y")
                {
                    Console.WriteLine("ok then talk to awsomme guy next to you for futher details ");
                }
                else
                {
                    Console.WriteLine("Tell the person bheind you the timing which works best for you?");
                }
            }
            else
            {
                Console.WriteLine("how about this weekend , last saturday was ? what about this sat will work for me [Y]?");
                String choice_day3 = Console.ReadLine().ToUpper();
                if(choice_day3 == "Y")
                {
                    Console.WriteLine("cool then , its was lovely talkking to you ");
                }
            }




        }
    }
}
