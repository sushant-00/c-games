using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            ////int[] result = Addonetoarrayelements(arr);
            //int[] result_substract = Substractint(arr);
            //foreach(int i in result_substract)
            //{
            //    Console.WriteLine(i);

            //}
            //numberDelegate number1 = Addone;

            int[] result = ChangeArrayElements(arr, Addone);
            foreach(int i in result)
            {
                Console.WriteLine(i);

            }
            int[] Ys = ChangeArrayElements(arr,Substractone);
            foreach (int i in Ys)
            {
                Console.WriteLine(i);

            }



        }
        public delegate int numberDelegate(int number);

        static int[] ChangeArrayElements(int[] ch , numberDelegate operation) {
            int[] result = new int[ch.Length];
            for (int i=0;i<ch.Length; i++)
            {
                result[i] = operation(ch[i]);


            }
            return result;
        }

        static int Addone(int number) => number + 1;
        static int Substractone(int number) => number - 1;

        static int Doubleone(int number) => number * 2;

        //static int[] Addonetoarrayelements(int[] newarry)
        //{
        //    int[] result = new int[newarry.Length];
        //    for (int i = 0;i< newarry.Length;i++)
        //    {
        //        result[i] = newarry[i] + 1;
        //    }
        //    return result;

        //}

        //static int[] Substractint(int[] newarry)
        //{
        //    int[] result = new int[newarry.Length];
        //    for(int j=0;j < result.Length; j++)
        //    {
        //        result[j] = newarry[j] - 1;
        //    }
        //    return result;

        //}
    }
}
