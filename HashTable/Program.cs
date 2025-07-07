using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashingTable();

            hashTable.Add("name", "John Doe");
            hashTable.Add("age", 30);
            hashTable.Add("city", "New York");

            Console.WriteLine("name: " + hashTable["name"]);
            Console.WriteLine("age: " + hashTable["age"]);
            Console.WriteLine("city: " + hashTable["city"]);

            var searchResult = hashTable.Search("age");
            Console.WriteLine("Search result for 'age': " + (searchResult ?? "Not found"));

            hashTable.Remove("city");
            Console.WriteLine("city removed");

            var removedSearchResult = hashTable.Search("city");
            Console.WriteLine("Search result for 'city' after removal: " + (removedSearchResult ?? "Not found"));

            hashTable.Add("name", "Jane Smith");
        }
    }
}
