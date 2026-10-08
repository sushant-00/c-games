using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_inhertance
{
    internal class Student:Teacher
    {
        string s_name { get; set; }
        public Student()
        {
            Console.WriteLine("student is called");
        }
        public void S_display()
        {
            Console.WriteLine($"_name");
        }
    }
}
