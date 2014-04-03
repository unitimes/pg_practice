using System;

namespace Ex01
{
	public class Star
	{
		public static void Main (String[] args)
		{
			for(int i = 1; i <= 5; i++)
			{
				for(int j = 1; j <= i; j++)
					Console.Write("*");
				Console.WriteLine();
			}
		}
	}
}
