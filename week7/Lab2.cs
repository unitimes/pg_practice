using System;
using System.Collections.Generic;
using System.Linq;

class Lab2 {
	public static void Main() {
		List <int> ll = new List<int>();
		while(true) {
			int t = Convert.ToInt32(Console.ReadLine());
			if(t == -999)
				break;
			if(ll.IndexOf(t) == -1) {
				ll.Add(t);
			} else {
				ll.Remove(t);
			}
			foreach(int i in ll)
				Console.Write("{0} ", i);
		}
	}
}

