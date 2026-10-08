using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExample
{
    public class Calculator
    {
        public int add(int x , int y)
        {
            return x + y;
        }

        public int substract(int x , int y)
        {
            return x - y;
        }

        public int multiplication(int x , int y)
        {
            return x * y;
        }

        public decimal division(int x , int y)
        {
            return x / y;
        }
    }
}
