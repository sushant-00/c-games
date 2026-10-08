using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filehandling_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DriveInfo obj = new DriveInfo("C");
            Console.WriteLine("Drvie name "+ obj.Name);
            Console.WriteLine("Drive type"+ obj.DriveType);
            Console.WriteLine("Is ready " + obj.TotalSize);


            DriveInfo[] f1 = DriveInfo.GetDrives(); 
            foreach(DriveInfo d1 in f1)
            {
                Console.WriteLine(d1.Name);

            }
            
            if (File.Exists("D:\\TEMP_Files\\28june\\june_0\\example"))
            {
                using(StreamWriter s12 = new StreamWriter("D:\\TEMP_Files\\28june\\june_0\\example" , true))
                {
                    s12.WriteLine("says hellow 1");
                    s12.WriteLine("mango");

                    
                }
            }


            /*

            using(FileStream fs = new FileStream("D:\\TEMP_Files\\28june\\june_0\\example", FileMode.Create))
            {
                StreamWriter s1 = new StreamWriter(fs);
                s1.Write("hello world");
                s1.Close();

            }
            */

            if (File.Exists("D:\\TEMP_Files\\28june\\june_0\\example"))
            {
                using (StreamReader s12 = new StreamReader("D:\\TEMP_Files\\28june\\june_0\\example", true))
                {
                    //string s1 = s12.ReadToEnd();
                    //Console.WriteLine(s1);
                    string line;
                    while( (line = s12.ReadLine())!= null)
                    {
                        Console.WriteLine(line);



                    }


                }
            }




        }
    }
}
