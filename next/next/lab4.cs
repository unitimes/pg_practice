using System;

namespace next
{
	public class Circle {
		public int x;
		public int y;
		public int r;

		public Circle(int x, int y, int r) {
			this.x = x;
			this.y = y;
			this.r = r;
		}
	}

	class CircleTest {
		static void Main(String[] args) {
			Circle c1, c2;
			String tempstr;
			Boolean result;
			int x;
			int y;
			int r;

			Console.WriteLine ("원충돌 테스트");
			Console.Write ("circle1 X?");
			tempstr = Console.ReadLine ();
			x = Convert.ToInt32 (tempstr);
			Console.Write ("circle1 Y?");
			tempstr = Console.ReadLine ();
			y = Convert.ToInt32 (tempstr);
			Console.Write ("circle1 R?");
			tempstr = Console.ReadLine ();
			r = Convert.ToInt32 (tempstr);

			c1 = new Circle (x, y, r);

			Console.Write ("circle2 X?");
			tempstr = Console.ReadLine ();
			x = Convert.ToInt32 (tempstr);
			Console.Write ("circle2 Y?");
			tempstr = Console.ReadLine ();
			y = Convert.ToInt32 (tempstr);
			Console.Write ("circle2 R?");
			tempstr = Console.ReadLine ();
			r = Convert.ToInt32 (tempstr);

			c2 = new Circle (x, y, r);

			result = ((c1.x - c2.x) * (c1.x - c2.x) + (c1.y - c2.y) * (c1.y - c2.y)) > ((c1.r + c2.r) * (c1.r + c2.r));
			//Console.Write (result);
			if (!result)
				Console.WriteLine ("두 원은 충돌합니다.");
			else
				Console.WriteLine ("두 원은 충돌하지 않습니다.");
		}
	}
}