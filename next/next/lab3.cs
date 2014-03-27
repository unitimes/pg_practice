using System;

namespace next
{
	public class Student {
		public String name;
		public int kor;
		public int math;
		public double avg;
	}
	class Test
	{
		public static void Main (string[] args)
		{
			Student s1 = new Student ();
			s1.name = "Lim";
			s1.kor = 80;
			s1.math = 90;
			s1.avg = (s1.kor + s1.math) / 2;

			Student s2 = new Student ();
			s2.name = "Bae";
			s2.kor = 50;
			s2.math = 90;
			s2.avg = (s2.kor + s2.math) / 2;

			double tavg = (s1.avg + s2.avg) / 2;

			Console.WriteLine ("{0}의 평균은 {1} 입니다.", s1.name, s1.avg);
			Console.WriteLine ("{0}의 평균은 {1} 입니다.", s2.name, s2.avg);
			Console.WriteLine ("{0}과 {1}의 전체 평균은 {2} 입니다.", s1.name, s2.name, tavg);
		}
	}
}