
//using day_6;

//test test1 = new();
//Console.WriteLine(sum(12, 22));

//int sum(int x,int y)
//{
//    return x + y;
//}



//Greed("Mansur");

//void Greed(string name)
//{
//    Console.WriteLine($"Hello: {name}");
//}


//void AddOne(ref int number)
//{
//    number+=1;
//}
//int value = 10;
//AddOne(ref value);
//Console.WriteLine(value);
//void OneNum(ref int num) 
//{
//    num = 0;
//    Console.WriteLine(num);
//}
//int b = 12;
//OneNum(ref b);
//b = 13;
//Console.WriteLine(b);

//int Factorial(int n)
//{
//    if (n <= 1) return 1;
//    return n * Factorial(n - 1);
//}
//Console.WriteLine(Factorial(6));

//int FibonacciIterative(int n)
//{
//    if(n==0)return 0;
//    if (n==1)return 1;
//    int prev1 = 0, prev2 = 1, current = 0;
//    for (int i = 2;i <= n; i++)
//    {
//        current = prev1 + prev2;
//        prev1 = prev2;
//        prev2 = current;
//    }
//    return current;
//}
//Console.WriteLine(FibonacciIterative(6));


//int Fibonacci(int n)
//{
//    if (n == 0) return 0;
//    if (n == 1) return 1;
//    return Fibonacci(n - 1) + Fibonacci(n - 2);
//}
//Console.WriteLine(Fibonacci(6));

// 4
//int StepChislo(int n, int y)
//{
//    if(y == 0) return 1;
//    return n * StepChislo(n,y-1); 
//}
//Console.WriteLine(StepChislo(10, 2)); // 100

// 1
//double GetPow(int a, int b) 
//{
//    return Math.Pow(a, b);
//}
//Console.WriteLine(GetPow(3, 2)); // 9

// 2
//void AddOne(ref int number)
//{
//    Console.WriteLine(number);
//     number += 10;  
//};
//int num = 5;
//AddOne(ref num);
//int num2 = 10;
//AddOne(ref num2);
//Console.WriteLine(num2);


//Console.WriteLine(value); // 12

// 3
//void SumAndRaz(int a, int b, out int sum, out int raz)
//{
//    sum = a + b;
//    raz = a - b;
//}
//int sum;
//SumAndRaz(8, 3, out sum, out int raz);
//Console.WriteLine(sum + raz); // 16


Console.WriteLine("Калькулятор");
int a = GetUserInput("Введите первое число: ");
int b = GetUserInput("Введите второе число: ");
int oper = GetUserInput("Что вы хотите сделать: \n 1. Сложить, 2. Вычесить, 3. Умножить ");
int result = ProcessCalc(a, b, oper);
Console.WriteLine($"Результат расчета равен: {result}");
int GetUserInput(string what)
{
    Console.WriteLine(what);
    string input = Console.ReadLine();
    int num = int.Parse(input);
    return num;
}
int ProcessCalc(int a,int b, int oper)
{
    int res = 0;
    if (oper == 1)
       res = a + b;
    else if (oper == 2)
        res = a - b;
    else if (oper == 3)
        res = a * b;
    else
        Console.WriteLine("Введите правильный оператор!!!");
    return res;
}



