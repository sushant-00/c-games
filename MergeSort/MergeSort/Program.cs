namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,4,3,2,1};
           int [] soretedarr = MergeSort(arr);
            
            Console.WriteLine(string.Join(',' , soretedarr));
        }

        static int[] MergeSort(int[] arr)
        {
           if(arr.Length == 1)
            {
                return arr;
            };

            int mid = arr.Length / 2;

            int[] left1 = MergeSort(arr[0..mid]);
            int[] right = MergeSort(arr[mid..arr.Length]);

            return Merge(left1, right);

        }

        static int[] Merge(int[]left , int[]right)
        {
            int[] mixarr = new int[left.Length + right.Length];


            int i = 0;
            int j = 0;
            int k = 0;
            while(i<left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    mixarr[k] = left[i];
                    i++;
                    k++;
                }
                else 
                {
                    mixarr[k] = right[j];
                    j++;
                    k++;
                }

                


                
            }
            while (i < left.Length)
            {
                mixarr[k] = left[i];
                i++;
                k++;

            }
            while (j < right.Length)
            {
                mixarr[k] = right[j];
                j++;
                k++;
            }
            return mixarr;

        }
    }
}
