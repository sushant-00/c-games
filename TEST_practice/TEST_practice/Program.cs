using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Badclass b1 = new Badclass();
            //Console.WriteLine(1.0==1.0m);
           int  a = 20;
            object b = a;
             a = 30;
            Console.WriteLine(b);
            
            int? x = null;
            int y = x ?? 5;
            Console.WriteLine(y);
            
            int a = 20;
            object z = a;//boxing
            int y = (int)z;
            Console.WriteLine(y);   
            

            string s1 = "hello";
            string s2 = "he" + "lo";
            Console.WriteLine(object.ReferenceEquals(s1,s2));
            
            int i = 0;
            Console.WriteLine(i++ == ++i);
            
            int abc = 10;
            Console.WriteLine(abc+"5");
            
            int[] a = { 2, 3, 4 };
            int[] b = a;
            b[0] = 10;
            Console.WriteLine(a[0]);
            
            int x = int.MaxValue;
            x++;
            Console.WriteLine(x);
            
            string s = null;
            Console.WriteLine(s.Length);
            
            var a = new {Name = "ravi"};
            var b = new {Name = "ravi" };
            Console.WriteLine(object.ReferenceEquals(a,b));
            Console.WriteLine(a.Equals(b));
            
            int x = 20;
            Console.WriteLine(x.GetType().IsValueType);
            
            var a = Type.GetType("System.String");
            Console.WriteLine(a.IsClass);
            
            int[] arr = new int[] {1,2,3 };
            Console.WriteLine(arr.Skip(5).FirstOrDefault());
            
            int i = 0;
            for (; i < 5; i++)
                for (; i < 3; i++)
                    Console.Write(i);
            
            try { throw null; }
            catch (Exception) { Console.WriteLine("Ex"); };
            
            try { int[] arr = new int[2]; arr[3] = 0; }
            catch (IndexOutOfRangeException) { Console.WriteLine("Index"); }
            finally { Console.WriteLine("End"); }
            
            try { throw new InvalidOperationException(); }
            catch (Exception e) when (e is ArgumentException) { Console.WriteLine("Arg"); }
            finally { Console.WriteLine("Finally"); };
            
            try { int x = int.Parse("abc"); }
            catch (FormatException) { Console.WriteLine("Format"); }
            catch (Exception) { Console.WriteLine("Other"); }
            
            File.WriteAllLines("lines.txt", new string[] { "A", "B", "C" });
            var lines = File.ReadLines("lines.txt");
            Console.WriteLine(lines.Count());
            
            using (var sw = new StreamWriter("data.txt"))
            {
                sw.Write("123");
            }
            Console.WriteLine(File.ReadAllText("data.txt"));
            
            var list = new List<int> { 1, 2, 3 };
            var result = list.Where(x => x > 1).Select(x => x * 2).ToList();
            Console.WriteLine(result[0]);
            
            var stack = new Stack<int>();
            stack.Push(1); stack.Push(2); stack.Push(3);
            Console.WriteLine(stack.Pop() + stack.Peek());
            */
                 class A { public virtual string Msg() => "A"; }
        class B : A { public new string Msg() => "B"; }
        A obj = new B();
        Console.WriteLine(obj.Msg()); 
                



























        }
}
        
    }
}

