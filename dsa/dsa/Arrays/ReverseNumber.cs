using System;
namespace dsa.Arrays
{
    public class ReverseNumber
    {
        public ReverseNumber()
        {
        }

        public void ReverseANumber(int number)
        {
            int currentSum = 0;
            while(number != 0)
            {
                currentSum = currentSum * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine(currentSum);
        }
    }
}
