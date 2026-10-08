using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_cons_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Company comp = new Company();
            //comp.CompanyDirector();

            Company comp2 = new Company("wipro");
            comp2.CompanyDirector();

            Company comp = new Company();
            //comp.CompanyDirector();
        }
    }
}
