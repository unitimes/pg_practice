using System;

namespace Next {
	public class Next {
		public static int[] ReadInts(String msg) {
			Console.Write(msg + ": ");
			String[] temp = Console.ReadLine().Split(' ');
			int[] arr = new int[temp.Length];
			for(int i = 0; i < temp.Length; i++)
				arr[i] = Convert.ToInt32(temp[i]);
		
			return arr;
		}
	}

	class Test {
		static void Main(String[] args) {
			int[] arr = Next.ReadInts("input test numbers");
			foreach (int i in arr) {
				Console.WriteLine(i);
			}
		}
	}
}
