using day_13.models;

//try
//{
//    Console.WriteLine("Введите возраст: ");
//    string input = Console.ReadLine();
//    int age = int.Parse(input); // Может вызвать FormatException

//    if (age < 0 || age > 120)
//    {
//        throw new InvalidAgeException("Возраст должен быть  от 0 до 120.");
//    }

//    Console.WriteLine($"Возраст: {age}");

//}catch (FormatException ex)
//{
//    Console.WriteLine($"Ошибка формата: {ex.Message}");
//}
//catch (InvalidAgeException ex)
//{
//    Console.WriteLine($"Ошибка возраста: {ex.Message}");
//}

try
{
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 >= 0)
    {
        throw new FormatException("Число должен быть положительным");
    }
    //} else if (number2 >= 0) 
    //{
    //    throw new FormatException("Число должен быть положительным");
    //}

    if (number2 == 0)
    {
        throw new DivideByZeroException("Деление на ноль невозможно!");
    }

    int result = number1 / number2;

    Console.WriteLine($"Возраст: {result}");

} catch (FormatException)
{
    Console.WriteLine("Ошибка: Введите корректное числовое значение.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
