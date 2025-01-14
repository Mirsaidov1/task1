using System;

public class Animal
{
	public string Name { get; set; }
	public string Sound { get; set; }
	public Animal()
	{
	}

	public void MakeSound()
	{
        Console.WriteLine($"Имя: {Name} Звук: {Sound}");
	}

}
