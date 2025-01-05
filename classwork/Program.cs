
//for (int i = 1; i <= 10; i++)              //День_4_Практика 
//{
//    Console.WriteLine($"5 * {i} = {i * 5}");
//}

//Console.WriteLine("Введите число a: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < a; i++)
//{
//    i++;
//    Console.WriteLine($"{i}");
//}
//for (int i = 0; i < b; i++)
//{
//    Console.WriteLine($"{i}");
//}

//int a = 0;
//do {
//    a++;
//    Console.WriteLine(a); 

//} while (a <= 10);

//while (a <= 10)
//{

//    Console.WriteLine(a);
//    a++;
//}



//int a = 3; 
//int c = 2; 
//Console.WriteLine("Угадайте число от 0 до 10. У вас есть 3 попытки.");
//while (a > 0)
//{
//    Console.WriteLine("Введите число: ");
//    string userInput = Console.ReadLine();
//    if (int.TryParse(userInput, out int input) && input >= 0 && input <= 10)
//    {
//        if (input == c)
//        {
//            Console.WriteLine($"Поздравляем! Вы угадали правильное число: {c}");
//            return;
//        }
//        else
//        {
//            Console.WriteLine("Неверно! Попробуйте снова.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Введите число от 0 до 10.");
//    }
//    a--;
//    Console.WriteLine($"Осталось попыток: {a}");
//}
//Console.WriteLine("Попытки закончились. Правильное число было: 2.");



//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine($"Квадрат числа {i} : {i * i}");
//}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
for (int i = 1; i <= a; i++)
{
    b *= i;
}
Console.WriteLine($"Факториал числа: {a} = {b}");