using System;

namespace Ex04
{
	public class Star4
	{
		public static void Main (String[] args)
		{
			int i = 1;

			do {
				int j = 1;
				while (j <= 6 - i) {
					Console.Write ("*");
					j++;
				}
				i++;
				Console.WriteLine();
			} while (i <= 5);
		}
	}
}
