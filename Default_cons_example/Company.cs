using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_cons_example
{
    public class Company
    {
        
        public Company()
        {
            Console.WriteLine("Comany");
        }
        public void CompanyDirector()
        {
            Console.WriteLine("DirectorList");
        }
        public Company(String sistercom)
        {
            Console.WriteLine("sister company :" + sistercom);
        }
    }
}
