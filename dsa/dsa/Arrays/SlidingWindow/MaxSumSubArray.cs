using System;
using System.Collections.Generic;

namespace dsa.Arrays.SlidingWindow
{
//Given an array of integers and a number K.Write a program to find the maximum sum of a subarray of size K.

//Input:
//First line of input contains a single integer T which denotes the number of test cases. Then T test cases follows.First line of each test case contains two space separated integers N and K where N denotes the number of elements.Second line of each test case contains N space separated integers which denotes the elements of the array.
//Output:
//For each test case print the maximum sum of a subarray of size K.


//Constraints:
//1<=T<=100
//1<=N<=105
//1<=K<=N

//Example:
//Input:
//2
//4 2
//100 200 300 400
//9 4
//1 4 2 10 23 3 1 0 20
//Output:
//700
//39
    public class MaxSumSubArray
    {
        public MaxSumSubArray()
        {
            int[] arr1 = new int[] { 100, 200, 300, 400 }; //max sum =700,k=2
            int[] arr2 = new int[] { 1, 4, 2, 10, 23, 3, 1, 0, 20 }; //max sum=39,k=4
            int size = 2;
            Console.WriteLine($"Max Sum of Sub Array is {FindMaxSum(arr1,size)}");
        }

        public int FindMaxSum(int[] arr,int k)
        {
            int a_point = 0;
            int b_point = k;

           
            int currSum = 0;
            for (int i = 0; i < k; i++)
            {
                currSum += arr[i];
            }
            int maxSum = currSum;

            //Fixed sliding window of size k
            while (b_point < arr.Length)
            {
                //Removing the element at front
                //and adding the new element
                currSum = currSum - arr[a_point] + arr[b_point];
                maxSum = Math.Max(maxSum, currSum);
                a_point++;
                b_point++;
               
            }
            return maxSum;
        }
    }
}
