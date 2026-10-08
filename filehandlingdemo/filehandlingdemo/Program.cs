using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filehandlingdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = "D:\\TEMP_Files\\Dempfile.txt";
            /*FileStream f1 = new FileStream(Filepath, FileMode.OpenOrCreate);
            f1.Close();
            Console.WriteLine("path has been created and path is : D:\\\\TEMP_Files\\\\Dempfile.txt");
            Console.ReadKey();
            //writing using Filestream object 
            FileStream f1 = new FileStream(Filepath, FileMode.Append);

            byte[] bytedata = Encoding.Default.GetBytes("i love c# progrraming language simle");
            f1.Write(bytedata, 0, bytedata.Length);
            f1.Close();

            //reading using file stream object 
            */
            FileStream newstream = new FileStream(Filepath, FileMode.Open);
            string filecontent;
            using(StreamReader s1 = new StreamReader(newstream))
            {
                filecontent = s1.ReadToEnd();

            }
            Console.WriteLine(filecontent);



            

        }
    }
}
