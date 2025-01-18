using System;

public class Car
{
	public string Mark { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }

	public void Deconstruct(out string mark, out string model, out int year)
	{
		mark = Mark;
		model = Model;
		year = Year;
	}


	public Car()
	{
	}
}
