using System;

class Program {
	static void Main() {
		Console.WriteLine("Hello claent!\nMy program have 2 command");
		string? nums = null;
		char[] pas = new char[8];
		Random rand = new Random();
		while (true) {
			Console.Write("Enter command(passwd or exit)");
			nums = Console.ReadLine();
			if ((nums != "passwd" && nums != "exit") || nums == null) {
				Console.WriteLine("invalid command");
				continue;
			}
			if (nums == "passwd") {
				int index1 = rand.Next(0, 7);
				pas[index1] = (char)rand.Next(65, 90);
				int index2 = 0;
				while ((index2 = rand.Next(0, 7)) == index1);
				pas[index2] = (char)rand.Next(97, 122);
				for (int i = 0; i < 8; ++i) {
					if (i == index1 || i == index2) {
						continue;
					}
					pas[i] = (char)rand.Next(48, 57);
				}
				Console.Write("your passwd: ");
				foreach(char sim in pas) {
					Console.Write(sim);
				}
				Console.WriteLine(" ");
			}
			else {
				break;
			}
		}
	}
}

