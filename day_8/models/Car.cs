using System;

public class Car
{
    private int _year;

    public string Color {  get; set; }
	public string Brand {  get; set; }
    public int Year
    {
        get
        {
            if (_year > 1978)
            {
                Console.WriteLine("Машина больше 1978 года");
            }
            else
            {
                Console.WriteLine("Машина уже старая");
            }
            return _year;  
        }
        set
        {
            _year = value;  
        }
    }

    public Car()
	{
	}


	public void GetInfo()
	{
		Console.WriteLine($"{Color} {Brand} {Year}");
	}
}
