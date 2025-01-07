Console.WriteLine("Введите число a: ");       // Задание_2
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int start = Math.Min(a, b);
int end = Math.Max(a, b);
int sum = 0;
for (int i = start; i <= end; i++)
{
    sum += i;
}
Console.WriteLine("" + sum);


//Console.WriteLine("Введите число a: ");         // Задание_2
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("\n");
//for (int i = 2; i <= a; i++)
//{
//    Console.WriteLine(i);
//    i++;
//}
//Console.WriteLine("\n");
//for (int i = 0; i <= b; i++)
//{
//    i++;
//    Console.WriteLine(i);
//}



//int a = 5;                  // Задание_3_Прямоугольник
//int b = 15;
//for (int i = 0; i < a; i++)
//{
//    for (int j = 0; j < b; j++)
//    {
//        if (i == 0 || i == a - 1 || j == 0 || j == b - 1)
//        {
//            Console.Write("*");
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();
//}



//int a = 10;                      // Задание_3_Прямоугольный_треугольник
//for (int i = 0; i < a; i++)
//{
//    for (int j = 0; j < a; j++)
//    {
//        if (i == j || i == a - 1 || j == 0)
//        {
//            Console.Write("*");
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();
//}




//int a = 10;                      //  Задание_3_Равносторонний_треугольник
//for (int i = 0; i <= a; i++)
//{
//    for (int j = 0; j < a - i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 0; k < (2 * i + 1); k++)
//    {
//        if (k == 0 || k == (2 * i) || i == a)
//        {
//            Console.Write("*");
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine("");
//}



//int a = 5;        // Задание_3_Ромб
//for (int i = 0; i <= a; i++)
//{
//    for (int j = 0; j < a - i + 2; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 0; k < (2 * i + 1); k++)
//    {
//        if (k == 0 || k == 2 * i)
//        {
//            Console.Write("*");
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();
//}
//for (int i = a - 1; i >= 0; i--)
//{
//    for (int j = 0; j < a - i + 2; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 0; k < (2 * i + 1); k++)
//    {
//        if(k == 0 || k == 2 * i)
//        {
//            Console.Write("*");
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();
//}



//double Nv = 1000;      // Задание_4
//double Tv = Nv;
//Console.Write("Введите процент: ");
//double P = Convert.ToDouble(Console.ReadLine());
//if (P <= 0 || P >= 25)
//{
//    Console.WriteLine("Введите корректный процент: ");
//    return;
//}
//int months = 0;
//while (Tv <= 1100)
//{
//    Tv *= (1 + P / 100);
//    months++;
//}
//Console.WriteLine($"Количество месяцев: {months}");
//Console.WriteLine($"Итоговый размер вклада: {Tv:F2}");
