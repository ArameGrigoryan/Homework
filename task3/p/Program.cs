using System;
class Exempel {
	int a = 9;
	int b = 7;
}
class Program {
	static void Main() {
		Exempel ex = new Exempel();
		Console.WriteLine(ex.GetType());
	}
}
