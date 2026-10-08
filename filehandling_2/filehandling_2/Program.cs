
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filepath = "D:\\TEMP_Files";
            string directorypath  = "D:\\TEMP_Files\\28june";
            if (!Directory.Exists(directorypath))
            {
                for(int i = 0;i<=5;i++)
                   
                {
                    Directory.CreateDirectory("D:\\TEMP_Files\\28june");
                    if (!Directory.Exists(directorypath + $"\\june_{i}"))
                    {
                        Directory.CreateDirectory(directorypath +  $"\\june_{i}");


                    }

                }

            }
            


            
            /*if (Directory.Exists(filepath))
            {
                string[] allFiles = Directory.GetFiles(filepath);
                foreach(string file in allFiles)
                {
                    Console.WriteLine(file);


                }
                Console.WriteLine(allFiles.Count());


            }
            else
            {
                //File.AppendAllText(filepath, "\n hello team , good day");
                
                

            }
            //read all files 
            //string Filecontents = File.ReadAllText(filepath);
            //var Attribute_1 = File.GetAttributes(filepath);
            //Console.WriteLine(Attribute_1.c);

            */




        }
    }
}
