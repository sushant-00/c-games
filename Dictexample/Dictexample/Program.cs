using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(3, "three");
            dict1.Add(1,"One");
            dict1.Add(2,"two");

            Console.WriteLine("dictoinary count :"+ dict1.Count());
            if (dict1.Count> 0)
            {
                foreach (KeyValuePair<int ,string> item in dict1)
                {
                    Console.WriteLine($"key is :{item.Key} , value is : {item.Value}");


                }

            }

        }
    }
}
