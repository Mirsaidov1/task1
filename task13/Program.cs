// Задание_1 Обработка пользовательских данных
try
{
    Console.WriteLine("Имя: ");
    string name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(name))
    {
        throw new ArgumentNullException("Пользователь ввел пустое поле.");
    }

    Console.WriteLine("Возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age < 18 || age > 65)
    {
        throw new ArgumentOutOfRangeException("Возраст должен быть от 18 до 65.");
    }

    Console.WriteLine("Зарплата: ");
    double salary = Convert.ToDouble(Console.ReadLine());
    if (salary <= 0)
    {
        throw new ArgumentException("Зарплата меньше нуля.");
    }
    Console.WriteLine($" Сотрудник: {name}\n Возраст: {age}\n Зарплата: {salary}");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

// Задание_2 Создание пользовательских исключений
//try
//{
//    Console.WriteLine("Имя: ");
//    string name = Console.ReadLine();

//    if (string.IsNullOrWhiteSpace(name))
//    {
//        throw new ArgumentNullException("Пользователь ввел пустое поле.");
//    }

//    Console.WriteLine("Возраст: ");
//    string input = Console.ReadLine();
//    int age = int.Parse(input);

//    if (age < 18 || age > 65)
//    {
//        throw new InvalidAgeException("Возраст должен быть от 18 до 65.");
//    }

//    Console.WriteLine("Зарплата: ");
//    double salary = Convert.ToDouble(Console.ReadLine());
//    if (salary <= 0)
//    {
//        throw new InvalidSalaryException("Зарплата меньше нуля.");
//    }
//    Console.WriteLine($" Сотрудник: {name}\n Возраст: {age}\n Зарплата: {salary}");
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (InvalidAgeException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch (InvalidSalaryException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}


