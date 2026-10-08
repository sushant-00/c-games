using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTABLeexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add(1, "one");
            h1.Add(2, "two");
            h1.Add(3, "three");
            h1.Add("2", "hello");
            h1.Remove("2");
            Console.WriteLine(1.GetHashCode());
            Console.WriteLine(h1.Count);


            /*foreach (DictionaryEntry a in h1)
            {
                Console.WriteLine($"key:{a.Key} and value :{a.Value}");


            }*/
        }
    }
}
