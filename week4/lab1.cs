using System;

class Lab1 {
	static void Main(String[] args) {
		bool flag = true;
		int i = 0;
		int sum = 0;
		while(flag){
			int n = 0;
			Console.Write("Enter Nums: ");
			String temp =  Console.ReadLine();
			n = Convert.ToInt32 (temp);
			if (n == -1)
				break;
			sum += n;
			i++;
		}
		Console.WriteLine("Sum is {0}", sum);
		Console.WriteLine("Avg is {0}", (double)sum/i);
	}
}
