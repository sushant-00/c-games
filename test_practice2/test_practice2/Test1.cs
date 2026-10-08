using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_practice2
{
    public class Test1
    {
        
        
    }
    class A { public virtual string Msg() => "A"; }
    class B : A { public new string Msg() => "B"; }
}
