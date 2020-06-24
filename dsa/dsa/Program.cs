using System;
using DataStructures.Arrays;
using dsa.Algorithms.Searching;
using dsa.Arrays;
using dsa.Arrays.SlidingWindow;
using dsa.Arrays.Strings;
using dsa.LinkedList;
using dsa.Trees;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberOfIslands number = new NumberOfIslands();
            Console.WriteLine(number.IslandCount());

            SpiralPrint sp = new SpiralPrint();
            sp.Print();

            PascalTriangle pt = new PascalTriangle();
            pt.Generate(6); pt.Print();

            MedianOfSortedArrays ms = new MedianOfSortedArrays();
            Console.WriteLine(ms.MedianOf2SortedArrays(ms.array1,ms.array2));

            FindtheMissingNumber fn = new FindtheMissingNumber();
            Console.WriteLine(fn.FindtheMissingNumberMethod1());

            ContainsDuplicate cd = new ContainsDuplicate();
            Console.WriteLine(cd.isDuplicateMethod2());

            ReversedLinkedList rl = new ReversedLinkedList();
            rl.reversedList();

            ReverseNumber rn = new ReverseNumber();
            rn.ReverseANumber(12345);

            LinearSearch ls = new LinearSearch();
            BinarySearch bs = new BinarySearch();

            ZigZag zz = new ZigZag();
            Console.WriteLine(zz.Convert("PAYPALISHIRING", 3));

            BinaryTree bt = new BinaryTree();
            bt.InorderTraverse(bt.root);
            Console.WriteLine();
            bt.PreorderTraverse(bt.root);
            Console.WriteLine();
            bt.PostorderTraverse(bt.root);

            RotateArray ra= new RotateArray(3);
            //SearchRotatedArray sr = new SearchRotatedArray(3);
            //Console.WriteLine(sr.Find());

            FindSumSarray fS = new FindSumSarray();
            MaxSumSubArray mxSum = new MaxSumSubArray();
        }
    }
    
}
