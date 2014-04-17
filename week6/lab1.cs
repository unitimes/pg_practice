using System;

namespace Week6 {
	public class Lab1 {
	public static void Main(String[] args) {
		int[] days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		int mon = 0;
		int date = 0;
		int sum = 0;
		String[] day = {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};

		String[] inputs = Console.ReadLine().Split(' ');
		mon = Convert.ToInt32(inputs[0]);
		date = Convert.ToInt32(inputs[1]);
		
		for(int i = 0; i < (mon - 1); i++) {
			sum = sum + days[i];
		}

		sum = sum + date;
		Console.WriteLine("{0}", day[sum%7]);
	}
	}
}
