using System;

public class Student
{
	public string Name;
	public int Age;
	public int[] Grade;

	public Student()
	{
	}
    public void GetInfo()
    {
        Console.WriteLine($" Студент: {Name} \n Возраст: {Age} \n Оценка: {string.Join(", ", Grade)}.");
    }
	
	public bool IsExcellent()
	{
        double AverageGrade = Grade.Average();

        if (AverageGrade >= 4.5)
        {
            Console.WriteLine(" Студент отличник.");
            return true;
        }
        else
        {
            Console.WriteLine(" Студент двоечник.");
            return false;
        }
    }
}
