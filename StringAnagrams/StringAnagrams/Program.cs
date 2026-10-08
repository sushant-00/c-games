namespace StringAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "listts";
            string s2 = "listtt";

            Dictionary<char, int> words1 = new Dictionary<char, int>();
            Dictionary<char, int> words2 = new Dictionary<char, int>();
            bool isAnagram = true;
            if (s1.Length == s2.Length)
            {


                for (int x = 0; x < s1.Length; x++)
                {
                    if (words1.ContainsKey(s1[x]))
                    {
                        words1[s1[x]]++;
                    }
                    else
                    {
                        words1[s1[x]] = 1;
                    }

                }
                for (int x = 0; x < s2.Length; x++)
                {
                    if (words2.ContainsKey(s2[x]))
                    {
                        words2[s2[x]]++;
                    }
                    else
                    {
                        words2[s2[x]] = 1;
                    }

                }
                foreach(var x in words1)
                {
                    if (!words2.ContainsKey(x.Key) || words2[x.Key] != x.Value)
                    {
                        isAnagram = false;

                    }


                    
                }
                if (isAnagram)
                {
                    Console.WriteLine("string is anagram !");

                }
                else
                {
                    Console.WriteLine("string is not anagram plz try again maaa!");

                }
            }
            else
            {
                Console.WriteLine("string is not anagrams plz try again man!");

            }



        }
    }
}
