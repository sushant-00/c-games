using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace filehandlings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringpath = "D:\\TEMP_Files\\nefile";
            
            using(StreamWriter s1 = new StreamWriter(stringpath , true))
            {
                s1.WriteLine("start" + DateTime.Now);
                for(int i =0;i<= 5; i++)
                {
                    s1.WriteLine(i);

                }
                
                s1.WriteLine("end" + DateTime.Now);
            }
        }
    }
}
