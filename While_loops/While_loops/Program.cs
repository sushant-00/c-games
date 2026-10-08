using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            //reverse a number 
            int number1 = 56789;
            while (number1 > 0)
            {
                Console.Write(number1%10);
                number1 = number1 / 10;
            }
            

            //sum of digits 
            int digit1 = 5431;
            int sum = 0;
            while(digit1>0)
            {
                sum += digit1 % 10;
                digit1 /= 10;


            }
            Console.WriteLine(sum);
            
            //check if number is palindrome or not 
            //121
            int number2 = 1212;
            int numb22 = number2;
            int rev = 0;
            while (number2 > 0)
            {
                rev =  (rev*10 + number2 % 10);
                
                number2 /= 10;
                
            }
            if(numb22 == rev)
            {
                Console.WriteLine("number2 is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
            
            //fibonachii using while 
            //fib = n + n-1 (0,1,1,2,3,5)
            int number = 4;
            int a = 0;
            int b = 1;
            while (number > 0)
            {
                Console.WriteLine(a);
                int temp = a + b;
                a = b;
                b = temp;
                number--;
            }
            
            //check prime using while - check if numb%i == 0 tll i = math.Sqrt(numb);
            //1num > 1 else no prime
            //num till underrootnumber 
            bool isprime = true;
            int number = 7;
            int i = 2;
            while (i<= Math.Sqrt(number))
            {
                if(number%i == 0)
                {
                    isprime = false;
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
                


            }

            

            //count digits 
            int digi11 = 1234;
            int count = 0;
            while (digi11 > 0)
            {
                count++;
                digi11 /= 10;
            }
            Console.WriteLine(count);

            

            //checking that  if age  greter than 22??
            int age;
            do
            {
                Console.WriteLine("enter your  age ?");
                age = int.Parse(Console.ReadLine());
            }
            */
            for(int i = 0;i<= 4; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

           




            

           

            
        }
    }
}
