using System;

class LongestWord
{
	public void Run()
	{
		Console.WriteLine("Hello claent..");
		Console.Write("Enter the words count: ");
		int count = Convert.ToInt32(Console.ReadLine());
		string[] str = new string[count];
		for (int i = 0; i < count; ++i)
		{
			Console.Write("Enter word: ");
			str[i] = Console.ReadLine();
		}
		WordLength(str);
	}
	public void WordLength(params string[] str)
	{
		int max = 0;
		string? res = null;
		foreach (var s in str)
		{
			if (s.Length > max)
			{
				max = s.Length;
				res = s;
			}
		}
		Console.WriteLine("It is the longest word: {0}\nlength: {1}", res, max);
	}
}
class Program
{
	static void Main()
	{
		LongestWord word = new LongestWord();
		word.Run();
	}
}
