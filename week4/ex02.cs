using System;

namespace Ex02
{
	public class Star2
	{
		public static void Main (String[] args)
		{
			for(int i = 1; i <= 5; i++)
			{
				for(int j = 1; j <= 6-i; j++)
					Console.Write("*");
				Console.WriteLine();
			}
		}
	}
}
