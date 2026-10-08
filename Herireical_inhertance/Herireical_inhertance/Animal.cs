using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herireical_inhertance
{
    public class Animal
    {
        public void sound()
        {
            Console.WriteLine("animal barks");
        }

    }
    public class Dog : Animal
    {
        public void Dog_bark()
        {
            Console.WriteLine("dogs barks");
        }
    }
    public class Cat : Animal
    {
        public void Cat_sound()
        {
            Console.WriteLine("cats does meww");
        }
    }
}
