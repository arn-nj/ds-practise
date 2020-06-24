using System;
public class FindSumSarray
{

	public FindSumSarray()
	{
		int sum = 12;
		int[] arr = new int[] { 1, 2, 3, 4, 5 };
		Console.WriteLine($"find continous sum of {sum} subarray {{1,2,3,4,5}}");
		FindSum(arr, sum);
	}

	private void FindSum(int[] a, int Fsum)
	{
		int i = 0;
		int j = 0;
		int sum = a[i];
		while (j < a.Length)
		{
			
			if (sum == Fsum)
			{
				Console.WriteLine(i+1 + " till " + (j+1));
				break;
			}
			if (sum < Fsum)
			{
				j++;
				sum += a[j];
			}
			if (sum > Fsum)
			{
				sum -= a[i];
				i++;
				
			}
			
		}
	}
}