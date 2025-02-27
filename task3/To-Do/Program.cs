using System;
public class To_Do 
{
	string _discription;
	public string Discription 
	{
		get { return _discription; }
		set { _discription = value; }
	}

	bool _flag;
	public bool Flag 
	{
		get { return _flag; }
		set { _flag = value; }
	}
	public To_Do(string Discription, bool Flag) 
	{
		this.Discription = Discription;
		this.Flag = Flag;
	}
}
public class List_to_do 
{
		List<To_Do> array = new List<To_Do>();
		public List_to_do() 
		{
			array = new List<To_Do>();
		}
		public void Add_to_do() 
		{
			Console.Write("Enter to-do:");
			string? tmp = Console.ReadLine();
			To_Do elem = new To_Do(tmp, false);
			array.Add(elem);
		}
		public void Remove_to_do() 
		{
			Console.Write("Import the index of the row to be removed: ");
			int index = Convert.ToInt32(Console.ReadLine());
			array.RemoveAt(index);
		}
		public void Complite_to_do() 
		{
			Console.Write("Enter index of the row to-do: ");
			int index = Convert.ToInt32(Console.ReadLine());
			array[index].Flag = true;	
		}
		public void Print_to_do()
		{
			foreach (var tmp in array) 
			{
				Console.WriteLine($"Your task: {tmp.Discription}: is -> {tmp.Flag}");
			}
		}
}
class Program 
{
	static void Main() 
	{
		List_to_do node = new List_to_do();
		Console.WriteLine("Hello client...");
		Console.WriteLine("Add, Sub, (Done)mark completed tasks or print");
		while (true) 
		{
			Console.Write("Enter command: ");
			string? com = Console.ReadLine();
			if (com.Equals("add", StringComparison.OrdinalIgnoreCase)) 
			{
				node.Add_to_do();
			}
			else if (com.Equals("sub", StringComparison.OrdinalIgnoreCase))
			{
				node.Remove_to_do();
			}
			else if (com.Equals("Done", StringComparison.OrdinalIgnoreCase)) 
			{
				node.Complite_to_do();
			}
			else if (com.Equals("print", StringComparison.OrdinalIgnoreCase))
			{
				node.Print_to_do();
			}
			else if (com.Equals("exit", StringComparison.OrdinalIgnoreCase))
			{
				Console.WriteLine("Good by.");
				break;
			}
			else {
				Console.WriteLine("invalid command!");
			}
		}
	}
}
