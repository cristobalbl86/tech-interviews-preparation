using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Arrays
{
    class IsSortedArray
    {
		public static void Main()
		{
			int[] a = { 1, 2, 3, 4, 5, 6 };

			Console.WriteLine(issorted(a, 0, 6));
			Console.WriteLine(issorted2(a, 6));

		}

		public static bool issorted(int[] a, int index, int n)
		{

			if (n == 0 || n == 1) return true;

			if (a[index] > a[index + 1]) return false;

			return issorted(a, index + 1, n - 1);

		}

		public static bool issorted2(int[] a, int n)
		{
			if (n == 0 || n == 1) return true;

			if (a[n - 2] > a[n - 1]) return false;

			return issorted2(a, n - 1);
		}
	}
}
