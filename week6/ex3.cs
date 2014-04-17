using System;
public class Data {
	public int id;
	public string name;
	public void Print() {
		Console.WriteLine("{0}:{1}", id, name);
	}
}
class Test {
	static void Main() {
		Data a = new Data();
