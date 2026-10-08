using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for(int i = 1; i <= 5; i++)
            {
                for(int j=1;j<= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }

            for(int i = 1; i <= 5; i++)
            {
                for(int j = 5; j >=i; j--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
            
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();

            }
            
            int n = 5;
            for (int i = 1; i <= (2 * n) - 1; i++)
            {
                if ( i>n)
                {
                    for(int j = 1;j<= (2*n) - i; j++)
                    {
                        Console.Write("*");

                    }



                }
                else {
                    for (int j = 1;j<=i;j++)
                    {
                        Console.Write("*");


                    }


                }
                ;
                Console.WriteLine();


            }
            */
            int n = 5;
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");

                }
                Console.Write("*");
                Console.WriteLine();
                for(int z = 1; z <= i; z++)
                {
                    Console.Write(" ");


                }



            }

        }
    }
}
