Console.WriteLine("Введите температуру в Цельсиях: ");
double celsiusInput = Convert.ToDouble(Console.ReadLine());
double fahrenheitOutput = TemperatureConverter.CelsiusToFahrenheit(celsiusInput); 
Console.WriteLine($"\n{celsiusInput}°C = {fahrenheitOutput}°F");

Console.WriteLine("Введите температуру в Фаренгейтах: ");
double fahrenheitInput = Convert.ToDouble(Console.ReadLine());
double celsiusOutput = TemperatureConverter.FahrenheitToCelsius(fahrenheitInput); 
Console.WriteLine($"\n{fahrenheitInput}°F = {celsiusOutput}°C");

