using System;
public class MoveTicket {
	
	private string _ticketName;
	public string Name {
		get { return _ticketName; }
		set { _ticketName = value; }
	}

	private int _ticketSetNumber;
	public int SetNumber {
		get { return _ticketSetNumber; }
		set { _ticketSetNumber = value; }
	}

	private bool _ticketSeatFlag;
	public bool SetFlag {
		get { return _ticketSeatFlag; }
		set { _ticketSeatFlag = value; }
	}
	public void BookTicket() {
		_ticketSeatFlag = true;
	}
	public  MoveTicket(string name, int SetNumber) {
		_ticketName = name;
		this.SetNumber = SetNumber;
	}
}
class Program {
	static void Main() {
		Console.Write("Enter movie name: ");
		string? name = Console.ReadLine();
		MoveTicket[] tickets = new MoveTicket[5];
		for (int i = 0; i < 5; ++i) {
			tickets[i] = new MoveTicket(name, i + 1);
		}
		int count = 5;
		Console.WriteLine("Hello claent...");
		while (true) {
			Console.WriteLine("At the moment we have one film {0}and {1} free space", name, count);
			for (int i = 0; i < 5; ++i) {
				if (tickets[i].SetFlag == false) {
					Console.WriteLine("{0})is exempt", tickets[i].SetNumber);
				}
				else {
					Console.WriteLine("{0})is engaged", tickets[i].SetNumber);
				}
			}
			while (true) {
				Console.Write("Do you want to buy a ticket?(Yes/No)");
				string? tmp = Console.ReadLine();
				if (string.Equals(tmp, "yes", StringComparison.OrdinalIgnoreCase) == true) {
					break;
				}
				else if (string.Equals(tmp, "no", StringComparison.OrdinalIgnoreCase) == true) {
					Console.WriteLine("Good by claent!");
					return;
				}
				else {
					Console.WriteLine("invalid command!");
				}
			}
			while (true) {
				Console.Write("Enter the seat number: ");
				int number = Convert.ToInt32(Console.ReadLine());
				if (number > 5 || number < 0) {
					Console.WriteLine("invalid number!");
					continue;
				}
				if (tickets[number-1].SetFlag == true) {
					Console.WriteLine("That chair is occupied");
					continue;
				}
				else {
					tickets[number-1].BookTicket();
					Console.WriteLine("A seat is reserved for you");
					break;
				}
			}
		}
	}
}
