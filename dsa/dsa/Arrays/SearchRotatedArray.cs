using System;
namespace dsa.Arrays
{
    public class SearchRotatedArray
    {
        public int[] arr = new int[] { 5,6,7,8,9,10,1,2,3,4};
        public int k;

        public SearchRotatedArray(int key)
        {
            k = key;
            Console.WriteLine("find 3 in sorted rotated array");
        }

        public int Find()
        {
            //Find the Pivot
            int p = FindPivot(arr,0,arr.Length-1);

            //Binary Search the [0....k]or[k+1...n-1] k - pivot
            if (p == -1) // there is no pivot which means array is not rotated
            {
                return BinarySearch(arr, 0, arr.Length, k);
            }
            if (arr[p] == k) return p;
            if (arr[0] <= k) return BinarySearch(arr, 0, p - 1, k);
            return BinarySearch(arr, p, arr.Length, k);

        }

        private int BinarySearch(int[] a, int low, int high, int k)
        {
            if (high < low) return -1;
            if (high == low) return low;

            int mid = low + high / 2;
            if (a[mid] == k) return k;
            else if (a[mid] > k) return BinarySearch(a, low, mid - 1, k);
            else
                return BinarySearch(a, mid, high, k);

        }

        private int FindPivot(int[] a,int i,int j)
        {
            if (i > j) return -1;
            if (i == j) return i;
            int mid = i + j / 2;

            if (mid < j && a[mid] > a[mid + 1])
                return mid;
            else if (mid > i && a[mid] < a[mid - 1])
                return mid - 1;
            if (a[i] >= a[mid]) return FindPivot(a, i, mid-1);
            return FindPivot(a, mid, j);
        }
    }
}
