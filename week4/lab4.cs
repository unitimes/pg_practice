using System;

namespace Lab4
{
	public class Hab
	{
		public static void Main (String[] args)
		{
			int init;
			int end;
			int step;
			int ans = 0;
			String ent;

			Console.WriteLine("input:");
			ent = Console.ReadLine();
			String [] temp = ent.Split(new Char [] {' '});
			while(temp.Length != 3)
			{
				Console.WriteLine("다시 입력해 주세요.");
				Console.WriteLine("input:");
				ent = Console.ReadLine();
				temp = ent.Split(new Char [] {' '});
			}
			init = Convert.ToInt32(temp[0]);
			end =  Convert.ToInt32(temp[1]);
			step = Convert.ToInt32(temp[2]);

			for(int i = init; i <= end; i += step)
			{
				ans += i;
				Console.WriteLine("" + ans);
			}
		}
	}
}
