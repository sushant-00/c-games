using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilehandlingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("D:\\TEMP_Files\\a.txt");
            //File.WriteAllText("D:\\TEMP_Files\\a.txt",
            //                            @"One
            //                            Two
            //                            Three");

            //Console.WriteLine(File.ReadAllLines("D:\\TEMP_Files\\a.txt").Length);
            //string path = Path.Combine("Folder", "Data", "abc.txt");

            //Console.WriteLine(path);

            //using (StreamWriter sw = new StreamWriter("D:\\TEMP_Files\\a.txt"))
            //{
            //    sw.WriteLine("ABC");
            //    sw.WriteLine("XYZ");
            //}

            //    using (StreamReader sr = new StreamReader("a.txt"))
            //    {
            //        //Console.WriteLine((char)sr.Read());
            //        //Console.WriteLine((char)sr.Read());
            //        Console.WriteLine(sr.ReadToEnd());


            //    }


            //ArrayList list = new ArrayList();

            //list.Add(10);
            //list.Add(20);
            //list.Add(10);

            //list.Remove(10);

            //foreach (var i in list)
            //    Console.Write(i + " ");

            //    ArrayList list = new ArrayList();

            //    for (int i = 0; i < 100; i++)
            //        list.Add(i);

            //    list.Clear();

            //    Console.WriteLine(list.Capacity > 0);
            //

            //ArrayList a = new ArrayList();

            //a.Add(10);

            //ArrayList b = a;

            //b.Add(20);

            //Console.WriteLine(a.Count);
            //ArrayList list = new ArrayList();

            ////list.Add(null);

            //Console.WriteLine(list.Count);
            //var list = new ArrayList { "Z", "A", 1 };
            //list.Sort();
            //Hashtable ht = new Hashtable();

            //ht["A"] = 100;

            //Console.WriteLine(ht.ContainsValue(100));
            //Hashtable ht = new Hashtable();

            //Console.WriteLine(ht["ABC"] == null);

            //Hashtable ht = new Hashtable();

            //ht["A"] = 1;
            //ht["B"] = 2;
            //ht["C"] = 3;

            //foreach (DictionaryEntry d in ht)
            //    Console.Write(d.Key + " ");
            //ArrayList list = new ArrayList() { 1, 2, 3 };

            //Stack s = new Stack(list);

            //foreach (var x in s)
            //    Console.Write(x + " ");
            //Queue q = new Queue();

            //q.Enqueue(100);

            //Console.WriteLine(q.Contains(100));
            //Console.WriteLine(q.Contains(200));
            Queue q = new Queue();

            q.Enqueue("100");

            int x = (int)q.Dequeue();
        }


    }
}
