using System;

public class Person
{
	public string Name;
	public int Age;
	public string City;

	public Person()
	{
	}

	public void Introduce()
	{
		Console.WriteLine($"Привет! Меня зовут: {Name}, мне {Age} лет, я из {City}-a.");
	}
}
