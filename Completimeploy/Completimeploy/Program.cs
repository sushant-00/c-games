using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Completimeploy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            int x = c1.Add(22, 33, 44);
            float y = c1.Add(2, 3.210f);
            Console.WriteLine(y);

        }
    }
}
