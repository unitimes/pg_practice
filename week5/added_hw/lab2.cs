using System;

namespace Week5 {
	public class Lab2 {
		public static void Main(String[] args) {
			int n;

			Console.Write("Enter a number: ");
			n = Convert.ToInt32(Console.ReadLine());

			for(int i = 0; i <= n; i++) {
				for(int j = 0; j < n; j++) {
					if(j < i)
						Console.Write('#');
					else
						Console.Write('*');
				}
				Console.WriteLine();
			}
		}
	}
}
