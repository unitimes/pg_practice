using System;
using System.Collections.Generic;
using System.Linq;

class Lab3 {
	public static void Main() {
		List <int> ll = new List<int>();
		string t1;
		int idx1;
		int idx2;
		int ent1;
		int ent2;

		for(int i = 1; i <= 10; i++) {
			ll.Add(i);
		}
		foreach(int i in ll)
			Console.Write("{0} ", i);
		Console.WriteLine();
		while(true) {
			t1 = Console.ReadLine();
			if(t1 == "-999")
				break;
			string[] t2 = t1.Split(' ');
			ent1 = Convert.ToInt32(t2[0]);
			ent2 = Convert.ToInt32(t2[1]);
			idx1 = ll.IndexOf(ent1);
			idx2 = ll.IndexOf(ent2);
			ll.RemoveAt(idx1);
			ll.Insert(idx1, ent2);
			ll.RemoveAt(idx2);
			ll.Insert(idx2, ent1);
			foreach(int i in ll)
				Console.Write("{0} ", i);
			Console.WriteLine();
		}
	}
}
