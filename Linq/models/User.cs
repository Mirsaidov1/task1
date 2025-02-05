using System;

public class User
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }

	public bool IsValidate()
	{
		return Age > 0 && Age < 120;
	}

	public string Email { get; set; }
	public string Password { get; set; }

	public User()
	{
	}
}
