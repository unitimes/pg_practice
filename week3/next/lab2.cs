using System;

namespace next
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			String name;
			double h;
			double b;
			Console.Write ("삼각형의 이름을 입력하세요: ");
			name = Console.ReadLine ();
			Console.WriteLine ();
			Console.Write ("삼각형의 높이를 입력하세요: ");
			h = Convert.ToDouble(Console.ReadLine ());
			Console.WriteLine ();
			Console.Write ("삼각형의 밑변을 입력하세요: ");
			b = Convert.ToDouble(Console.ReadLine ());
			Console.WriteLine ();
			Console.WriteLine ("{0}의 넓이={1}",name,h*b/2);
		}
	}
}