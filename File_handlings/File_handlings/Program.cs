
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_handlings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "D:\\TEMP_Files\\dotnet_1.txt";
            File.WriteAllText(filepath , "hello world");


        }
    }
}
