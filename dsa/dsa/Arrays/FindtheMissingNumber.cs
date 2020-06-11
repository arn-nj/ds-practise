using System;
namespace dsa.Arrays
{
    public class FindtheMissingNumber
    {
        public int[] input; 
        public FindtheMissingNumber()
        {
            input = new int[] { 1, 2, 3, 5, 6, 7, 8, 9 };
            Console.WriteLine("The Missing Number ");
        }

        //Method 1: Sum of N natural numbers - Sum of the array
        public int FindtheMissingNumberMethod1()
        {
            int sumOfN = (input.Length + 1) * (input.Length + 2) / 2;
            int sumOfInput = 0;
            foreach (var i in input)
                sumOfInput += i;

            return sumOfN - sumOfInput;
        }

        //Method2: (XOR of N number) XOR (XOR of array)
        public int FindtheMissingNumberMethod2()
        {
            int xorN = 0;

            for(int i = 0; i < input.Length + 1; i++)
            {
                xorN = xorN ^ i;
            }

            int xorArray = 0;
            foreach (var i in input)
                xorArray = xorArray ^ i;

            return xorN ^ xorArray;
        }
    }
}
