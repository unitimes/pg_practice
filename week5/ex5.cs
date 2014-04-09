using System;

public class Ex5 {
	public static int ReadInt(String msg) {
		Console.Write("{0}? ", msg);
		String r = Console.ReadLine();
		int x = Convert.ToInt32(r);
		return x;
	}

	public static double Divide(int x, int y) {
		double r = (double) x / y;
		return r;
	}

	static void Main(String[] args) {
		int a = ReadInt("A");
		int b = ReadInt("B");
		double x = Divide(a, b);
		Console.WriteLine(x);
	}
}
