using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_inhertance
{
    public class Quantum
    {
        public int course_id { get; set; }
        public Quantum()
        {
            Console.WriteLine("quantum physics course");
        }
        public void cousreInfo()
        {
            Console.WriteLine($"course{course_id}");
        }
    }
}
