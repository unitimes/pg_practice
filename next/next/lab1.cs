using System;

namespace next
{
	class Lab1
	{
		static void Main (String[] args)
		{
			int kor1, kor2;
			int math1, math2;
			double avg1, avg2, avg3;
			String name1, name2;

			Console.WriteLine ("===Score===");
			name1 = "임정민";
			name2 = "배철오";
			kor1 = 80;
			kor2 = 88;
			math1 = 90;
			math2 = 60;
			avg1 = (kor1 + math1) / 2.0;
			avg2 = (kor2 + math2) / 2.0;
			avg3 = (avg1 + avg2) / 2;
			Console.WriteLine ("AVG of {0}: {1}", name1, avg1);
			Console.WriteLine ("AVG of {0}: {1}", name2, avg2);
			Console.WriteLine ("AVG of {0}: {1}", "평균", avg3);
		}
	}
}