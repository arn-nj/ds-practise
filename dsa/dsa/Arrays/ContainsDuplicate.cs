using System;
using System.Collections.Generic;

namespace dsa.Arrays
{
    public class ContainsDuplicate
    {
        public int[] input;
        public ContainsDuplicate()
        {
            Console.WriteLine("Contains Duplicate");
            input = new int[] { 1, 2, 3, 4, 4, 5 };
        }

        //Method1: Sort and compare near by element
        public bool isDuplicateMethod1()
        {
            Array.Sort(input);

            for(int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1]) return true;

            }
            return false;
        }
        //Method2: Maintain a hashset
        public bool isDuplicateMethod2()
        {
            HashSet<int> sets = new HashSet<int>();
            foreach (var i in input)
            {
                if (sets.Contains(i)) return true;

                sets.Add(i);
            }
            return false;
        }

    }
}
