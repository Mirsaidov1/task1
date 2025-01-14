using System;

public class Personn
{
	public string firstName;
	public int age;
	public string lastName;
	public string email;
	public string address;
	public string phoneNumber;

	public Personn(int age = 18)
	{
		this.age = age;
	}
	public void GetInfo()
	{
        Console.WriteLine($" Имя: {firstName} Возраст: {age} \n");
	}


	public void GetDetailInfo()
	{
        Console.WriteLine($" {firstName} \n {lastName} \n {age} \n {email} \n {phoneNumber} \n {address}");
	}

}


