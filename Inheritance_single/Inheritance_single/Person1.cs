using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_single
{
    public class Person1 : Addharcard
    {
        public string Name { get; set; }
        public int age { get; set; }
        public Person1()
        {
            Console.WriteLine("person called");
        }
        public void Displayinfo()
        {
            Console.WriteLine($"name : {Name} and age : {age}");
        }
    }
}
