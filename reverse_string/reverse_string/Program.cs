using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Anjali";
            /*for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);

            }
            
            char[] revesre_array = s.ToCharArray();
            Array.Reverse(revesre_array);
            Console.WriteLine(new string(revesre_array));
            */
            for(int i = 0;i<= 5; i++)
            {
                for(int j = 5;j>= i; j--)
                {
                    Console.Write(" ");

                }
                for(int k = 0;k<= i; k++)
                {
                    if(i==0 || i==5 || k ==0 || k == i)
                    {
                        Console.Write("* ");
                        

                    }
                    else
                    {
                        Console.Write("  ");

                    }



                }
                Console.WriteLine();

            }


        }
    }
}
