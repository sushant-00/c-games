using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "D:\\TEMP_Files\\dotnet_1.txt";
            string filepath2 = "D:\\TEMP_Files\\dotnet_2";
            File.WriteAllText(filepath, "hello worldis 3 time");
            if (File.Exists(filepath))
            {
                //File.Delete(filepath);
                File.Copy(filepath, filepath2,true );
                Console.WriteLine("filedeleted");




            }
            else
            {
                

            }
        }
    }
}
