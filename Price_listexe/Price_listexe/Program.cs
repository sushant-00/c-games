using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Price_listexe
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Price> customers = new List<Price>()
            {
                new Price  { Product_name = "iphone", Price1 = 200, Status = true },
                new Price  { Product_name = "macbook", Price1 = 300, Status = true },
                new Price  { Product_name = "ipad", Price1 = 500, Status = true },
            };


            Console.WriteLine(  "product count : " + customers.Count);
            Console.WriteLine("product details:");


            foreach (var c1 in customers)
            {
                Console.WriteLine($"pname :{c1.Product_name} ,price: {c1.Price1},  status :{c1.Status}");


            }





        }
    }
}
