using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_inhertance
{
    public class Teacher :Quantum
    {
        public int teacher_id { get; set; }
        public Teacher()
        {
            Console.WriteLine("teacher called");
        }
        public string t_name { get; set; }
        public void Teacher_info()
        {
            Console.WriteLine($"t_id:{teacher_id} and t_name : {t_name}");
        }
    }
}
