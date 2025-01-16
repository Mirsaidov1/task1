using System;

public class Calculator
{
	public void Add(int a, int b)
	{
		int result = a + b;
		Console.WriteLine(result);
	}

    public void Add(int a, int b, int c)
    {
        int result = a + b + c;
        Console.WriteLine(result);
    }

    public int Add(int a, int b, int c, int d)
    {
        int result = a + b + c + d;
        Console.WriteLine(result);
        return result;
    }

    public void Add(double a, double b)
    {
        double result = a + b;
        Console.WriteLine(result);
    }

    public Calculator()
	{
	}


    public void Increment(ref int val)
    {
        val++;
        Console.WriteLine(val);
    }

    public void Increment(int val)
    {
        val++;
        Console.WriteLine(val);
    }

}
