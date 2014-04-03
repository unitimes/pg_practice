using System;

namespace Quiz
{
	public class lab2
	{
		public static void Main (String[] args)
		{
			Random r = new Random();
			int q_num = r.Next(1,11);
			int cnt = 0;
			int ans = 0;

			while(q_num != ans)
			{
				cnt++;
				Console.Write("예측값? ");
				String t_ans = Console.ReadLine();
				ans = Convert.ToInt32(t_ans);
				if(ans > q_num)
					Console.WriteLine("크다");
				else if(ans < q_num)
					Console.WriteLine("작다");
			}

			Console.WriteLine("{0}만에 맞추셨습니다.", cnt);
		}
	}
}
