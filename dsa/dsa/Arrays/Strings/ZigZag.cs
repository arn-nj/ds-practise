using System;
using System.Text;

namespace dsa.Arrays.Strings
{
    public class ZigZag
    {
        public ZigZag()
        {

        }

        public string Convert(string s, int numRows)
        {
            StringBuilder sb = new StringBuilder();
            if (s == null || s == "") return sb.ToString();

            //Create Array of string builder objects for numRows
            StringBuilder[] arr = new StringBuilder[numRows];
            for (int a = 0; a < numRows; a++)
            {
                arr[a] = new StringBuilder();
            }
            int i = 0; //iterator for traversing the string
            int j = 0; //iterator for traversing the string builder arrays
            while (i < s.Length)
            {
                for (j = 0; j < numRows && i < s.Length; j++)
                {
                    arr[j].Append(s[i++]);
                }
                for (j = numRows - 1; j > 0 && i < s.Length; j--)
                {
                    arr[j].Append(s[i++]);
                }
            }

            for (int k = 0; k < arr.Length; k++)
            {
                sb = sb.Append(arr[k]);
            }
            return sb.ToString();
        }
    }
}
