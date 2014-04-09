using System;

namespace Week5 {
	public class Lab1 {
		public static void Main(String[] args) {
			int m;
			int n;
			String[] inputs;
			
			Console.Write("Enter 'MxN': ");
			inputs = Console.ReadLine().Split('x');
			m = Convert.ToInt32(inputs[0]);
			n = Convert.ToInt32(inputs[1]);

			for(int i = 1; i <= m; i++) {
				for(int j = 1; j <= n; j++) {
					Console.Write("{0} ", i*j);
				}
				Console.WriteLine();
			}
		}
	}
}
