using System.Text;
using System.Collections;
namespace Stringspractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "sushant";
            //string b = "sushant";
            //b = "s1";
            string b = new string("sushant");
            b = "s12";
            //Console.WriteLine(object.ReferenceEquals(a,b));
            //Console.WriteLine(a.Equals(b));

            //from charr array to string 
            char[] ch = a.ToCharArray();
            ch[0] = 'Y';
            //Console.WriteLine(new string(ch));
            //Console.WriteLine((int)'z');
            //Console.WriteLine((char)('z'+ 1));
            //Console.WriteLine((int)('{'));
            //Console.WriteLine("sush" + new ArrayList());
            StringBuilder sb = new StringBuilder();
            
            for(int i = 0; i < 26; i++)
            {
               char ch1 = (char)('a' + i);
                sb.Append(ch1);
            }
            Console.WriteLine(sb.ToString());







        }
    }
}
