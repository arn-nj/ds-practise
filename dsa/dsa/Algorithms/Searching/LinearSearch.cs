using System;
namespace dsa.Algorithms.Searching
{
    public class LinearSearch
    {
        public int[] iArray;
        public LinearSearch()
        {
            iArray = new int[] { 2, 4, 5, 6, 8, 9, 1, 12, 56, 34 };
            Console.WriteLine("Linear Search:" +  Search(56));
        }

        public int Search(int num)
        {
            for (int i = 0; i < iArray.Length; i++)
                if (iArray[i] == num) return i;

            return -1;
        }
    }
}
