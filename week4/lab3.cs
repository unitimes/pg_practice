using System;

namespace Lab3
{
	public class GuGuDan
	{
		public static void Main (String[] args)
		{
			int dan = 0;
			while(dan < 1 || dan > 20)
			{
				Console.Write("단수를 입력하세요(1~20): ");
				dan = Convert.ToInt32(Console.ReadLine());
			}

			for(int i = 1; i <10; i++)
			{
				Console.WriteLine("{0} x {1} = {2}", dan, i, dan*i);
			}
		}
	}
}
