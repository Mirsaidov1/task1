//Console.WriteLine("Введите число a: ");       // День_4_Задание_2
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = Convert.ToInt32(Console.ReadLine());
//int start = Math.Min(a, b);
//int end = Math.Max(a, b);

//int sum = 0;
//for (int i = start; i <= end; i++)
//{
//    sum += i;
//}
//Console.WriteLine("" +  sum);


//Console.WriteLine("Введите число a: ");         // День_4_Задание_2
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("\n");
//for (int i = 0; i <= a; i++)
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



//int a = 5; // День_4_Задание_3_Прямоугольник
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



//int a = 10; //День_4_Задание_3_Прямоугольный_треугольник
//int b = 5;

//for (int i = 0; i <= a; i++)
//{
//    for (int j = 0; j <= b; j++)
//    {
//        if (i == 0 || i ==  b - 1)
//        {
//            Console.Write("*");
//        }
//    }
//    Console.WriteLine();
//}


//int a = 10; //День_4_Задание_3_Равносторонний_треугольник
//int b = 5;

//for (int i = 0; i <= a; i++)
//{
//    for (int j = 0; j <= b; j++)
//    {
//        if (i == 0 || i == b - 1)
//        {
//            Console.Write("*");
//        }
//    }
//    Console.WriteLine();
//}


int a = 10; //День_4_Задание_3_Ромб
int b = 5;

for (int i = 0; i <= a; i++)
{
    for (int j = 0; j <= b; j++)
    {
        if (i == 0 || i == b - 1)
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}