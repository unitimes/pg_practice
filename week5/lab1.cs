using System;

namespace Lab1
{
	public class StarTree
	{
		public static void Main(String[] args)
		{
			int line;
			Console.Write("숫자를 입력하세요: ");
			line = Convert.ToInt32(Console.ReadLine());
			for(int i = 1; i <= line; i++)
			{
				for(int j = 1; j <= line-i; j++)
				{
					Console.Write(" ");
				}
				for(int k = 1; k<=2*i -1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}
		}
	}
}
