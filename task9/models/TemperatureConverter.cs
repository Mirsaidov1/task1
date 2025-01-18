using System;

static class TemperatureConverter
{
	public static double CelsiusToFahrenheit(double celsius)
	{
		return celsius * 9 / 5 + 32;
	}

	public static double FahrenheitToCelsius(double fahrenheit)
	{
		return (fahrenheit - 32) * 5 / 9; 
	}

    static TemperatureConverter()
	{
	}
}
