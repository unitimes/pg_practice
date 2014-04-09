using System;

namespace Week5 {
	public class Lab3 {
		public static void Main(String[] args) {
			int mat = 0;
			int row = 0;
			int column = 0;
			String[] str_pos;
			String[,] matrix;

			while(true) {
				Console.Write("Enter a number: ");

				try {
					mat = Convert.ToInt32(Console.ReadLine());
					if(mat < 1)
						throw new Exception("Too low value");
					break;
				} catch (Exception e) {
					Console.WriteLine("You've entered wrong input(s).\nEnter Only a number bigger than 0, please!!");
				}
			}
			matrix = new String[mat, mat];

			for (int i = 0; i < mat; i++) {
				for (int j = 0; j < mat; j++) {
					matrix[i,j] = "*";
					Console.Write(matrix[i,j]);
				}
				Console.WriteLine();
			}

			while(true) {
				while(true) {
					Console.Write("Enter a position like 'x y': ");
	 				str_pos = Console.ReadLine().Split(' ');
					if (str_pos.Length != 2) {
						Console.WriteLine("You've entered wrong type input(s).\nTry Again.");
						continue;
					}
					try {
						row = Convert.ToInt32(str_pos[0]);
						column = Convert.ToInt32(str_pos[1]);
						if (row > (mat - 1) || column > (mat - 1))
							throw new Exception("Too big value");
						break;
					} catch (Exception e) {
						Console.WriteLine("You've entered non-numbers or too big numbers.\nTry Again.");
					}
				}
				if (row < 0 || column < 0)
					break;
				if (matrix[row, column].Equals(" "))
					Console.WriteLine("You've already remove the value of that position!");
				else 
					matrix[row, column] = " ";
				for (int i = 0; i < mat; i++) {
					for (int j = 0; j < mat; j++) {
						Console.Write(matrix[i,j]);
					}
					Console.WriteLine();
				}
			}
			Console.Write("End");
		}
	}
}
