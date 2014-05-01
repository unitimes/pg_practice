using System;
using System.Collections.Generic;
using System.Linq;

class Lab1 {
	static void Main() {
		List <int> ll = new List<int>();
		for (int i = 0; i < 10; i++) {
			ll.Add(i);
		}
		while(true) {
			int t = Convert.ToInt32(Console.ReadLine());
			if(t == -99)
				break;
			ll.Insert(ll.Count/2, t);
			foreach(int i in ll)
				Console.WriteLine(i);
			Console.WriteLine();
			Console.WriteLine();
		}
	}
}
