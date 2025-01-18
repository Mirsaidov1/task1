// Задание_1
Console.WriteLine("Введите температуру в Цельсиях: ");
double celsiusInput = Convert.ToDouble(Console.ReadLine());
double fahrenheitOutput = TemperatureConverter.CelsiusToFahrenheit(celsiusInput);
Console.WriteLine($"\n{celsiusInput}°C = {fahrenheitOutput}°F");

Console.WriteLine("Введите температуру в Фаренгейтах: ");
double fahrenheitInput = Convert.ToDouble(Console.ReadLine());
double celsiusOutput = TemperatureConverter.FahrenheitToCelsius(fahrenheitInput);
Console.WriteLine($"\n{fahrenheitInput}°F = {celsiusOutput}°C");
// Задание_2
Car car = new Car
{
    Mark = "Mers",
    Model = "w124",
    Year = 1993
};

//void (mark, model, year) = car;
car.Deconstruct(out string mark, out string model, out int year);
Console.WriteLine($"Марка: {mark}, Модель: {model}, Год выпуска {year}.");
 