using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //linear search
            int target = 3;
            int[] arr = { 2, 3, 7, 8 };
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
    }
}
