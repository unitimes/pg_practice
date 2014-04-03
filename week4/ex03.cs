using System;

namespace Ex03
{
	public class Star3
	{
		public static void Main (String[] args)
		{
			int i = 1;
			while (i <= 5) {
				int j = 1;
				while (j <= i) {
					Console.Write ("*");
					j++;
				}
				Console.WriteLine();
				i++;
			}
		}
	}
}
