using System;
namespace dsa.Arrays
{
    public class RotateArray
    {
        public int[] Array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public int times=0;
        public RotateArray(int k)
        {
            times = k;
            Console.WriteLine($"Rotate Array {k} times");
            Method4();
            Print();

        }
        //Method 1 Use temp array
        public void Method1()
        {
            int[] temp = new int[times];
            for(int i=0;i<times;i++)
            {
                temp[i] = Array[i];
            }
            int j = 0;
            for(int i= times; i < Array.Length; i++)
            {
                Array[j] = Array[i];
                j++;
            }
            int k = 0;
            for(int i = j; i < Array.Length; i++)
            {
                Array[i] = temp[k]; k++;
            }
    
        }

        //Method 2 - One by One Rotate
        public void Method2()
        {
            for (int i = 0; i < times; i++)
                RotateLeftByOne();
        }

        private void RotateLeftByOne()
        {
            int temp = Array[0];
            for (int i = 0; i < Array.Length - 1; i++)
            {
                Array[i] = Array[i + 1];
            }
            Array[Array.Length - 1] = temp;
        }

        public void Print()
        {
            foreach (var item in Array)
            {
                Console.Write(item+ " " );
            }
            Console.WriteLine();
        }

        //Method 3: Use sets & juggling
        public void Method3()
        {
           for(int i = 0;i< GCD(times, Array.Length); i++)
            {
                int temp = Array[i];

                int j = i;
                while (true)
                {
                    int k = j + times;
                    if (k >= Array.Length) k = k - Array.Length;
                    if (k == i) break;
                    Array[j] = Array[k];
                    j = k;
                }
                Array[j] = temp;
            }
        }
        //Reversal Algorithm
        public void Method4()
        {
            reverseArray(Array, 0, times - 1);
            reverseArray(Array, times, Array.Length - 1);
            reverseArray(Array, 0, Array.Length - 1);

        }

        public void Method5()
        {
            int i = times; 
            int j = Array.Length - times;

            while (i != j)
            {
                if (i < j)//A is shorter
                {
                    Swap(Array, times - i, times + j - 1, i);
                    j = j - i;
                }
                else
                {
                    Swap(Array, times - i, times, j);
                    i = i - j;
                }
            }
            Swap(Array, times - i, times, i);
        }

        private void Swap(int[] arr, int fi, int si, int d)
        {
                int i, temp;
                for (i = 0; i < d; i++)
                {
                    temp = arr[fi + i];
                    arr[fi + i] = arr[si + i];
                    arr[si + i] = temp;
                }
            
        }

        private void reverseArray(int[] array, int v1, int v2)
        {
            int low = v1;
            int high = v2;
            while (low <= high)
            {
                int temp = array[low];
                array[low] = array[high];
                array[high] = temp;
                low++;
                high--;
            }
        }

        private int GCD(int times, int length)
        {
            if (length == 0) return times;
            return GCD(times, times % length);
        }
    }
}
