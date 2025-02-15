using System;

class Program {
	static void Main() {
		Console.Write("Enter number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
        	while (num != 0) {
            		sum += num % 10;
            		num /= 10;
            		if (sum > 9 && num == 0) {
                		num = sum;
               	 		sum = 0;
            		}
        	}
		Console.WriteLine("result is: {0}", sum);
	}
}

