using System;
namespace dsa.Arrays
{
    public class MedianOfSortedArrays
    {
        public int[] array1;
        public int[] array2;
        public MedianOfSortedArrays()
        {
            Console.WriteLine("Median of Two Sorted Arrays");
            array1= new int[] { 1,5,7,9};
            array2 = new int[] { 2, 6, 8, 10, 12, 15 };
        }

        public double MedianOf2SortedArrays(int[] arr1, int[] arr2)
        {
            int m = arr1.Length;
            int n = arr2.Length;

            if (m == 0 && n == 0) return 0.0;
            if (m == 0) return MedianOf1SortedArray(arr2);
            if (n == 0) return MedianOf1SortedArray(arr1);

            //Make sure first array is having lowest elements
            if (m > n) return MedianOf2SortedArrays(arr2,arr1);


            //Binary Search in the first array for a pivot
            int low = 0;int high = m;

            while (low <= high)
            {
                //Pick a partition
                int Px = (low + high) / 2;
                //Since Left and right array should have equal number of elements
                int Py = (m + n + 1) / 2 - Px;

                int Lx = Px == 0 ? int.MinValue : arr1[Px - 1];
                int Rx = Px == m ? int.MaxValue : arr1[Px];
                int Ly = Py == 0 ? int.MinValue : arr2[Py - 1];
                int Ry = Py == m ? int.MaxValue : arr2[Py];

                if (Lx < Ry && Ly < Rx)
                {
                    if ((m + n) % 2 == 0)
                        return ((double)Math.Max(Lx, Ly) + Math.Min(Rx, Ry)) / 2;

                    return (double)Math.Max(Lx, Ly);
                }else if (Lx > Ry)
                {
                    high = Px - 1;
                }
                else
                {
                    low = Px + 1;
                }
            }
            return 0.0;

        }

        private double MedianOf1SortedArray(int[] arr)
        {
            if (arr.Length % 2 == 0)
            {
                return ((double)arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;

            }
            return (double)arr[arr.Length / 2];
        }
    }
}
