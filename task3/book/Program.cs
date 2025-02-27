using System;
public class Book {
	string title;
	string author;
	bool flag;

	public Book(string title, string author, bool flag) {
		this.title = title;
		this.author = author;
		this.flag = flag;
	}
	public bool BorrowBook() {
		if (this.flag == false) {
			return false;
		}
		this.flag = false;
		return true;
	}
	public bool ReturnBook() {
		if (this.flag == true) {
			return false;
		}
		this.flag = true;
		return true;
	}
	public void print() {
		Console.WriteLine($"this state is {this.flag}");
	}

}
class Program {
	static void Main() {
		Book[] ob = new Book[3];
		ob[0] = new Book("dog and cat", "Tumanyan", true);
		ob[1] = new Book("mi catil mexr", "Tumanyan", true);
		ob[2] = new Book("dog and nikol", "Tumanyan", true);
		Console.WriteLine("\t\tI am have this books\n\t0)dog and cat\n\t1)mi catil mexr\n\t2)dog and nikol");
		while (true) {
			Console.Write("Enter 0, 1, 2(enter -1 for exit): ");
			int num = -1;
			do {
				Console.Write("Enter number: ");
				num = Convert.ToInt32(Console.ReadLine());
			}while (num < -1 && num > 2);
			if (num == -1) {
				break;
			}
			Console.Write("Enter command get or set: ");
			string? com = Console.ReadLine();
			if (com == "set") {
				if (ob[num].ReturnBook() == false) {
					Console.WriteLine("I have htis book!");
				}
				else {
					Console.WriteLine("the book is set seccessfuly!");
				}
			}
			else if (com == "get") {
				if (ob[num].BorrowBook() == false) {
					Console.WriteLine("this book is not fund");
				}
				else {
					Console.WriteLine("you get this book");
				}
			}
		}
	}
}
