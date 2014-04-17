using System;

namespace Week6 {
	public class Lab2 {
		static void printNum(int m, int n) {
			for(int i = 1; i <= m; i++) {
				for(int j = 0; j < n; j++) {
					Console.Write("{0} ", (i + 5 * j));
				}
				Console.WriteLine();
			}
		}

		public static void Main(String[] args) {
			String[] inputs = Console.ReadLine().Split(' ');
			int row = Convert.ToInt32(inputs[0]);
			int column = Convert.ToInt32(inputs[1]);

			printNum(row, column);
		}
	}
}
