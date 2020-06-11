using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
    public class PascalTriangle
    {
        private List<List<int>> triangle = new List<List<int>>();
        public PascalTriangle()
        {
            Console.WriteLine("Pascal Triangle");
        }

        public void Generate(int numOfRows)
        {
            if (numOfRows == 0) return;
            //Add the first row
            List<int> firstRow = new List<int>() { 1 };
            triangle.Add(firstRow);

            //From second row- take the previous row and loop till i and add (j-1)th +jth element
            for (int i = 1; i < numOfRows; i++)
            {
                List<int> prevRow = triangle[i - 1];
                List<int> currentRow = new List<int>();

                currentRow.Add(1);

                //loop the prevRow
                for (int j = 1; j < i; j++)
                {
                    currentRow.Add(prevRow[j - 1] + prevRow[j]);

                }
                currentRow.Add(1);
                triangle.Add(currentRow);
            }
        }

        public void Print()
        {
            for (int i = 0; i < triangle.Count; i++)
                for (int j = 0; j < triangle[i].Count; j++)
                    Console.Write(triangle[i][j] + " ");
            Console.WriteLine();
        }
    }
}
