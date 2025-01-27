using System;

public class Employee
{
	public string Name { get; set; }
	public int Age { get; set; }
	public double Salary { get; set; }

	

	public Employee(string name, int age, double salary)
	{
		Name = name;
		Age = age;
		Salary = salary;
	}	
}
