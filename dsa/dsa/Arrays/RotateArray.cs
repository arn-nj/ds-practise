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
            Method3();
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

        private int GCD(int times, int length)
        {
            if (length == 0) return times;
            return GCD(times, times % length);
        }
    }
}
