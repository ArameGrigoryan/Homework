using System;

class Program {
		static void Main() {
			Random rand = new Random();
			char[,] mat = new char[10, 10];
			mat[rand.Next(0, 9), rand.Next(0, 9)] = 'X';
			for (int i = 0; i < 10; ++i) {
				for (int j = 0; j < 10; ++j){
					if (mat[i, j] == 'X') {
						Console.WriteLine("Hello cient");
						Console.WriteLine("X hide for index: {0},{1}", i, j);
						break;
					}
				}
			}
			
		}
}

