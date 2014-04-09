using System;

public class Ex3
{
	public static void DoublePrint(int x)
	{
		x = x * 2;
		Console.WriteLine(x);
	}

	static void Main(String[] args)
	{
		int x = 10;
		int y = 20;
		DoublePrint(x);
		DoublePrint(y);
		DoublePrint(30);
		Console.WriteLine("Main x: {0}", x);
	}
}
