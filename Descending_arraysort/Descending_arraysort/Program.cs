namespace Descending_arraysort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort the array in descending order plz!");
            int[] array = { 1, 2, 3, 4 };
            int i = 0;
            int j = array.Length-1;
            while (i < j)
            {
                int temp = array[j];

                array[j] = array[i];
                array[i] = temp;
                i++;
                j--;
            }

            foreach(var x in array)
            {
                Console.Write(x);
            }
        }
    }
}
