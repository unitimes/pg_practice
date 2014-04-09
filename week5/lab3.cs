using System;

namespace Lab3
{
	public class Arr
	{
		public static void Main(String[] args)
		{
			int num_arr1;
			int num_arr2;

			Console.Write("첫번째 배열 크기: ");
			num_arr1 = Convert.ToInt32(Console.ReadLine());
			int[,] mat_arr1 = new int [num_arr1, num_arr1];

			for(int i = 0; i < num_arr1; i++)
			{
				for(int j = 0; j < num_arr1; j++)
				{
					Console.Write("{0}{1}? ", i, j);
					mat_arr1[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			for(int i = 0; i < num_arr1; i++)
			{
				Console.Write("|");
				for(int j = 0; j < num_arr1; j++)
				{
					Console.Write("{0} ", mat_arr1[i,j]);
				}
	   			Console.Write("|");
				Console.WriteLine();
			}
			
			Console.Write("두번째 배열 크기: ");
			num_arr2 = Convert.ToInt32(Console.ReadLine());
			while(num_arr2 != num_arr1)
			{
				Console.WriteLine("첫번째 배열과 크기가 같아야 합니다.");
				Console.Write("두번째 배열 크기: ");
				num_arr2 = Convert.ToInt32(Console.ReadLine());
			}

			int[,] mat_arr2 = new int [num_arr2, num_arr2];

			for(int i = 0; i < num_arr2; i++)
			{
				for(int j = 0; j < num_arr2; j++)
				{
					Console.Write("{0}{1}? ", i, j);
					mat_arr2[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			for(int i = 0; i < num_arr2; i++)
			{
				Console.Write("|");
				for(int j = 0; j < num_arr2; j++)
				{
					Console.Write("{0} ", mat_arr2[i,j]);
				}
	   			Console.Write("|");
				Console.WriteLine();
			}
			
			Console.WriteLine("합 출력!!");
			for(int i = 0; i < num_arr2; i++)
			{
				Console.Write("|");
				for(int j = 0; j < num_arr2; j++)
				{
					Console.Write("{0} ", mat_arr1[i,j] + mat_arr2[i,j]);
				}
	   			Console.Write("|");
				Console.WriteLine();
			}
		}
	}
}
