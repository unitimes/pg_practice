using System;

public class Human {
	public static int no;
	public int id;
	public string name;
	public void SetID() {
		id = ++no;
	}
	public static void Init() {
		no = 0;
	}
}

class Test {
	public static void Main() {
		Human.Init();
		Human h1 = new Human();
		Human h2 = new Human();
		Human h3 = new Human();
		h1.SetID();
		h2.SetID();
		h3.SetID();
		Console.WriteLine(h1.id);
		Console.WriteLine(h2.id);
		Console.WriteLine(h3.id);
	}
}
