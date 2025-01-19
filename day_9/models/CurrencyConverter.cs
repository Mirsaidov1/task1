using System;

public static class CurrencyConverter
{
    private const double UsdToEurRate = 0.85; 
    private const double EurToUsdRate = 1.18; 
    private const double RubToUsdRate = 0.013; 

    public static double UsdToEur(double usd)
	{
		double eur = usd * UsdToEurRate;
		Console.WriteLine($"{usd} USD = {eur} EUR");
		return eur;
	}

	public static double EurToUsd(double eur)
	{
		double usd = eur * EurToUsdRate;
		Console.WriteLine($"{eur} EUR = {usd} USD");
		return usd;
	}

	public static double RubToUsd(double rub)
	{
		double usd = rub * RubToUsdRate;
		Console.WriteLine($"{rub} RUB = {usd} USD");
		return usd;
	}

}
