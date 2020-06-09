using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
    public class SpiralPrint
    {
        private List<List<int>> grid = new List<List<int>>();
        public SpiralPrint()
        {
            //Prepare the input Grid for testing

            grid.Add(new List<int>() { 1, 2, 3, 4, 5 });
            grid.Add(new List<int>() { 16, 17, 18, 19, 6 });
            grid.Add(new List<int>() { 15, 24, 25, 20, 7 });
            grid.Add(new List<int>() { 14, 23, 22, 21, 8 });
            grid.Add(new List<int>() { 13, 12, 11, 10, 9 });
            //grid.Add(new List<int>() { 1 });

            Console.WriteLine("Spiraly Print a matrix");
        }

        public void Print()
        {
            //Initialise Variables
            int i=0; //Iterators
            int row = 0, col = 0; //current row & column
            int rowlen = grid.Count;
            int collen = grid[0].Count;

            while(row<rowlen &&  col< collen)
            {
                //Print from left to right & inc row
                for (i = col; i < collen;i++)
                {
                    Console.Write(grid[row][i] + " ");

                }
                row++;

                //Print from top to bottom & dec colleng
                for (i = row; i < rowlen; i++)
                {
                    Console.Write(grid[i][collen-1] + " ");
                }
                collen--;

                //Print from right to left & dec rowlen
                for (i = collen-1; i >= col; i--)
                {
                    Console.Write(grid[rowlen-1][i] + " ");
                }
                rowlen--;

                //Print from bottom to top & inc col
                for (i = rowlen-1; i >= row; i--)
                {
                    Console.Write(grid[i][col] + " ");
                }
                col++;
            }
            Console.WriteLine();
        }
    }
}
