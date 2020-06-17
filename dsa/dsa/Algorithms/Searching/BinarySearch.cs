using System;
namespace dsa.Algorithms.Searching
{
    public class BinarySearch
    {
        public int[] iarray;
        public BinarySearch()
        {
            iarray = new int[] { 2, 4, 6, 8, 9, 12, 45, 56, 78, 90 };
            Console.WriteLine("Binary Search: "+ iterativeSearch(56));
        }

        private int iterativeSearch(int v)
        {
            int low = 0;
            int end = iarray.Length;
            //Iterative Binary Search
            while (low <= end)
            {
                int n = (low + end) / 2;
                if (iarray[n] > v)
                {
                    end = n;
                }else if (iarray[n] < v)
                {
                    low = n;
                }
                else { return n; }
            }
            return -1;
        }

       
    }
}
