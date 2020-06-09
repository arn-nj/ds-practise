using System;
using DataStructures.Arrays;

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
        }
    }
}
