using System;

public class Circle
{
	public double Radius;

	public double CalculateArea()
	{
        double area = Math.PI * Math.Pow(Radius, 2);
        Console.WriteLine($"Площадь круга: {area}");
        return area;
    }

	public double CalculateCircumference()
	{
        double circumference = 2 * Math.PI * Radius;
        Console.WriteLine($"Длина окружности: {circumference}");
		return circumference;	
	}

	public Circle()
	{
	}
}
