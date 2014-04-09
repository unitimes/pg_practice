using System;

namespace Lab2
{
	public class NumMatrix
	{
		public static void Main(String [] args)
		{
			int row;
			int column;

			row = ReadInt("Row");
			column = ReadInt("Column");
			//row = Convert.ToInt32(Console.ReadLine());
			//column = Convert.ToInt32(Console.ReadLine());

			for(int i = 0; i < row; i++)
			{
				for(int j = 0; j < column; j++)
				{
					//Console.Write(i + "" + j + " ");
					Console.Write("{0}{1} ", i, j);
				}
				Console.WriteLine();
			}
		}
		public static int ReadInt(String msg)
		{
			int ans;
			Console.Write(msg + ": ");
			ans = Convert.ToInt32(Console.ReadLine());
			return ans;
		}
	}
}
