using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
    public class NumberOfIslands
    {
        private List<List<int>> grid = new List<List<int>>();
        public NumberOfIslands()
        {
            //Prepare the input Grid for testing
            grid.Add(new List<int>() { 1, 1, 1, 1, 0 });
            grid.Add(new List<int>() { 1, 1, 0, 0, 0 });
            grid.Add(new List<int>() { 0, 0, 1, 0, 0 });
            grid.Add(new List<int>() { 0, 0, 0, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 1, 0 });

            Console.WriteLine("Number of Islands");
        }

        public int IslandCount()
        {
            //Intialise counter & iterators
            int count=0, i, j;

            for (i = 0; i < grid.Count; i++)
            {
                for (j = 0; j < grid[i].Count; j++)
                {
                    //if a grid element [i,j] equals to 1,
                    //Increase the counter
                    //Reset the whole island to zero by traversing in all direction recursively
                    if (grid[i][j] == 1)
                    {
                        count+=1;
                        resetIsland(grid, i, j); //Reset the current island by DFS
                    }
                }
            }

            return count;
        }
        
        //recursive function to traverse the two dimensional structure
        private void resetIsland(List<List<int>> grid, int i, int j)
        {
            //Base logic
            if (i < 0 || i >= grid.Count || j < 0 || j >= grid[i].Count || grid[i][j] == 0) return;

            //reset the current element
            grid[i][j] = 0;

            //Traverse and reset the elements in all 4 directions
            resetIsland(grid, i + 1, j);//up
            resetIsland(grid, i - 1, j);//Down
            resetIsland(grid, i, j + 1);//Right
            resetIsland(grid, i, j - 1);//Left
        }
    }
}
