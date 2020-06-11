using System;
using DataStructures.Arrays;
using dsa.Arrays;
using dsa.LinkedList;

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
        }
    }
}
