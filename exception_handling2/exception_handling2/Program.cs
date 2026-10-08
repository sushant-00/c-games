using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string response = Console.ReadLine();
            try
            {
                //int number = int.Parse(response);
                if(response == "snake")
                {
                    throw new NotSupportedException("i have not working in excat manner");
                }

            }
            catch (FormatException e)
            {
                //number = -1;
                
                Console.WriteLine($"i dont understand anyof it :{e.Message}");
                Console.WriteLine($"i dont understand anyof it :{e.Source}");
                Console.WriteLine($"i dont understand anyof it :{e.StackTrace}");

            }
            catch (OverflowException)
            {
                Console.WriteLine($"i dont understand anyof it :{response}");


            }
            */
            try
            {
                Console.WriteLine("divide by zero error :");
            }
            finally 
            {
                Console.WriteLine("java");

            }
        }
    }
}
