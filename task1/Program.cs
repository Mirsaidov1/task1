

//int age = 20;
//age = 22;
//Console.WriteLine($"Привет, мне {age} лет.");

//Console.WriteLine("Введите число: ");//Begin1
//int a = int.Parse(Console.ReadLine());
//int P = 4 * a;
//Console.WriteLine($"Периметр квадрата: {P}");



//Console.WriteLine("Введите число: ");   //Begin2
//int b = int.Parse(Console.ReadLine());
//double S = Math.Pow(b, 2);
//Console.WriteLine($"Площадь квадрата: {S}");



//Console.WriteLine("Введите число a: "); //Begin3
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = int.Parse(Console.ReadLine());
//int S = a * b;
//int P = 2 * (a + b);
//Console.WriteLine($"Площадь: {S}");
//Console.WriteLine($"Периметр: {P}");



//double pi = 3.14;                  //Begin4
//Console.WriteLine("Введите диаметр окружности: ");
//int d = int.Parse(Console.ReadLine());
//double L = pi * d;
//Console.WriteLine($"Длина: {L}");



//Console.WriteLine("Введите число: "); //Begin5
//int a = int.Parse(Console.ReadLine());
//double V = Math.Pow(a, 3);
//double S = 6 * Math.Pow(a, 2);
//Console.WriteLine($"{V}");
//Console.WriteLine($"{S}");



//Console.WriteLine("Введите число a: ");//Begin6
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число c: ");
//int c = int.Parse(Console.ReadLine());
//int V = a * b * c;
//int S = 2 * ((a * b) + (b * c) + (a * c));
//Console.WriteLine($"Объем = {V}");
//Console.WriteLine($"Площадь = {S}");


//double pi = 3.14; //Begin7
//Console.WriteLine("Введите радиус R: "); 
//int r = int.Parse(Console.ReadLine());
//double L = 2 * pi * r;
//double S = pi * Math.Pow(r, 2);
//Console.WriteLine($"Длина круга: {L}");
//Console.WriteLine($"Площадь круга: {S}");



//Console.WriteLine("Введите число a: "); //Begin8
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = int.Parse(Console.ReadLine());
//int C = (a + b) / 2;
//Console.WriteLine($"Среднее арифметическое число: {C}");



//Console.WriteLine("Введите неотрицательное число a: "); //Begin9
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите неотрицательное число b: ");
//int b = int.Parse(Console.ReadLine());
//double c = Math.Sqrt(a * b);
//Console.WriteLine($"Квадратный корень из их произведения: {c}");



//Console.WriteLine("Введите массу в кг: "); //integer2
//int m = int.Parse(Console.ReadLine());
//int summa = m / 1000;
//Console.WriteLine($"Масса в тоннах: {summa}");



//Console.WriteLine("Введите число А: ");//integer4
//int A = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число B: ");
//int B = int.Parse(Console.ReadLine());
//int C = A / B;
//Console.WriteLine($"Количество отрезков B, размещенных на А: {C}");



//Console.WriteLine("Введите число: ");  //if-else
//int hp = Convert.ToInt32(Console.ReadLine());
//if (hp % 2 == 0)
//{
//    Console.WriteLine("Число чётное");
//}
//else 
//{ 
//    Console.WriteLine("Число нечётное"); 
//}
//Console.ReadKey();



//Console.WriteLine("Введите число: ");         // if_1,2,3
//int a = Convert.ToInt32(Console.ReadLine());
//int i;
//if (a++ > 0)
//{
//    Console.WriteLine("Число положительное: " + a);
//}
//else if (a < 0)
//{
//    i = a - 2;
//    Console.WriteLine("Число отрицательное: " + i);
//}
//else
//{
//    a = 10;
//    Console.WriteLine("Число: " + a);
//}




//Console.WriteLine("Введите число от 1-12 для вывода месяца: ");
//int a = Convert.ToInt16(Console.ReadLine());

//switch (a)
//{
//    case 1:
//        {
//            Console.WriteLine("Январь");
//            break;
//        }
//    case 2:
//        {
//            Console.WriteLine("Февраль");
//            break;
//        }
//    case 3:
//        {
//            Console.WriteLine("Март");
//            break;
//        }
//    case 4:
//        {
//            Console.WriteLine("Апрель");
//            break;
//        }
//    case 5:
//        {
//            Console.WriteLine("Май");
//            break;
//        }
//    case 6:
//        {
//            Console.WriteLine("Июнь");
//            break;
//        }
//    case 7:
//        {
//            Console.WriteLine("Июль");
//            break;
//        }
//    case 8:
//        {
//            Console.WriteLine("Август");
//            break;
//        }
//    case 9:
//        {
//            Console.WriteLine("Сентябрь");
//            break;
//        }
//    case 10:
//        {
//            Console.WriteLine("Октябрь");
//            break;
//        }
//    case 11:
//        {
//            Console.WriteLine("Ноябрь");
//            break;
//        }
//    case 12:
//        {
//            Console.WriteLine("Декабрь");
//            break;
//        }
//    default:
//        Console.WriteLine("Неправильное число!");
//        break;
//}


//Console.WriteLine("Введите число a: "); //Выводит большое число
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine($"Число {a} больше");
//}
//else
//{
//    Console.WriteLine($"Число {b} больше");
//}

Console.WriteLine("Введите число a: "); //Вывод положительных чисел
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int Count = 0;
if (a > 0)
{
    Count++;
}

if (b > 0)
{
    Count++;
}

if (c > 0)
{
    Count++;
}

Console.WriteLine($"Количество положительных чисел: {Count}");

//int a = 5, b = 10;

//bool result1 = (a > 0 | b++ > 15); //b увеличевается
//Console.WriteLine($"{result1},b:{b}");

//bool result2 = (a > 0 || b++ > 15); //b не изменяется
//Console.WriteLine($"{result2},b:{b}");

//bool result3 = (a > 0 & b++ > 15); //b увеличевается b=10;
//Console.WriteLine($"{result3},b:{b}");

//bool result4 = (a > 0 && b++ > 15); //b не изменяется
//Console.WriteLine($"{result4},b:{b}");


