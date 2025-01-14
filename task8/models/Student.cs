using System;

public class Student
{
	public string Name;
	public int Age;
	public int Grade;

	public Student()
	{
	}
    public void GetInfo()
    {
        Console.WriteLine($" Студент: {Name} \n Возраст: {Age} \n Оценка: {Grade}.");
    }
	
	public bool IsExcellent()
	{
        if (Grade >= 5)
        {
            Console.WriteLine("Студент отличник.");
            return true;
        }
        else
        {
            Console.WriteLine("Студент двоечник.");
            return false;
        }
    }
}
