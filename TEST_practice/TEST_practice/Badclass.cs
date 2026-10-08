using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_practice
{
      public class Badclass
    {
        static Badclass()
            {
            throw new Exception("this is invalid ");

        }
        
}
}
