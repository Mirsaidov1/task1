// var fruits = new List<string> {"Apple", "Banana"};
// fruits.Add("Cherry");
// System.Console.WriteLine(string.Join(", ", fruits));
using System;
using System.Collections.Generic;

namespace Collections 
{
    class Program
    {
        static void Main(string[] args)
        {
            // var numbersCopy = new List<int> {1,2,3,4,5};
            // int[] arrayCopy = new int[3];
            // numbersCopy.CopyTo(2,arrayCopy,0,3);
            // System.Console.WriteLine(string.Join(", ", arrayCopy)); // 3, 4, 5


            // List<int> numbers = new
            // List<int>() { 2, 3, 4, 5};
            // numbers.Add(6);
            // numbers.AddRange(new int[] { 7, 8, 9});
            // numbers.Insert(0, 666);
            // numbers.RemoveAt(1);
            
            // Console.WriteLine(String.Join(", ", numbers));

            // numbers.Clear(); 

            // Console.WriteLine(numbers.Count);

            // foreach (int i in numbers)
            // {
            //     System.Console.WriteLine(i);
            // }

            // List<Person> people = new List<Person>(3);
            // people.Add(new Person() {Name = "Том"});
            // people.Add(new Person() {Name = "Билл"});

            // foreach (Person p in people)
            // {
            //     System.Console.WriteLine(p.Name);
            // }
            // System.Console.WriteLine();


            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(1, "Russian");
            countries.Add(2, "Great Britain");
            countries.Add(3, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");
            
            foreach(KeyValuePeir<int,string> keyValue in countries)
            {
                System.Console.WriteLine(keyValue + " - " + keyValue.Value);
            }

            string country = countries[4];

            countries[4] = "Spain";

            countries.Remove(2);
        }   
    }
    // public class Person
    // {
    //     public string Name { get; set; }
    // }


}