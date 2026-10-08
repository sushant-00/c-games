using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_handlers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship Titanic = new Ship();
            Titanic.Health = 100;
            //Titanic.TakeDamage(100);

            AlertSound station1 = new AlertSound(Titanic);
            Titanic.TakeDamage(100);


        }
    }
}
