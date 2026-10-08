using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaram_exe
{
    public class Alaram1
    {
        public event EventHandler AlaramRaise;

        public void Start()
        {
            Console.WriteLine("alaram is raised");
            AlaramRaise?.Invoke(this, EventArgs.Empty);
        }

    }

    public class Person1
    {
        public void Wakeup(object sender , EventArgs e)
        {
            Console.WriteLine("perso woke up");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Alaram1 a1 = new Alaram1();
            Person1 p1 = new Person1();
            a1.AlaramRaise += p1.Wakeup;
            a1.Start();
        }
    }
}
