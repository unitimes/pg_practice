using System;

namespace Test
{
	public class Cal
	{
		public static void Main(String[] args)
		{
			int a = 0;
			int b = 0;
			String[] input = Console.ReadLine().Split(new Char[] {' '});
			a = Convert.ToInt32(input[0]);
			for(int i = 0; i < input.Length; i++)
			{
				if(input[i].Equals("+"))
					a = a + b;
				else if(input[i].Equals("-"))
					a = a - b;
				else if(input[i].Equals("*"))
					a = a * b;
				else if(input[i].Equals("/"))
					a = a / b;
				else
					b = Convert.ToInt32(input[i]);
			}
			Console.Write("{0}", a);
		}
	}
}
