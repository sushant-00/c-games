using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace event_handlers
{
    public  class Ship
    {
        public event Action shipexploded;
        public int Health { get; set; }

        public void TakeDamage(int amount) {
            Health -= amount;
            if(Health <= 0)
            {
                shipexploded();
            }
        }
    }

    public class AlertSound
    {
        private void Onship_exploded() => playsound("explosion");

        public void playsound(string msg)
        {
            Console.WriteLine("ship is destroyed by iceberg");
        }
        public AlertSound(Ship s1)
        {
            s1.shipexploded += Onship_exploded;
        }




    }
}
