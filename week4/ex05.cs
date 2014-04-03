using System;

namespace Ex05
{
	public class Star5
	{
		public static void Main (String [] args)
		{
			int ent;

			Console.Write("반복횟수를 입력하세요: ");
			ent = Convert.ToInt32(Console.ReadLine());

			if(ent > 0)
			{
				for(int i = 1; i <= ent; i++)
				{
					for(int j = 1; j <= i; j++)
						Console.Write("*");
					Console.WriteLine();
				}
			}else{
				Console.Write("0보다 작거나 같은 수는 입력할 수 없습니다.");
			}
		}
	}
}
