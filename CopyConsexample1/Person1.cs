using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConsexample1
{
    public class Person1
    {
        private int _id;
        private string _name;

        public Person1 (int id,string name)
        {
            _id = id;
            _name = name;
        }

        public Person1(Person1 abhi)
        {
            _id = abhi._id;
            _name = abhi._name;

        }

        public void Display1()
        {
            Console.WriteLine(_id);
            Console.WriteLine(_name);

        }
    }

}
