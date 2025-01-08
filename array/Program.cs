
//int[] numbers = new int[] { -4, -3, -2, -1, 0, 1, 2, 3, 4, };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (i > 0)
//    {
//        sum++;
//    }
//}
//Console.WriteLine(sum);

//int[] array = { 1, 2, 3, 4, 5 };     // Сумма_массива
//int result = 0;
//for (int i = 0; i <= array.Length - 1; i++)
//{
//    result += array[i];
//}
//Console.WriteLine(result);

//int sum = 0;    
//for (int i = 0; i < numbers.Length; i++)
//{

//}


//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//for(int i = 0; i <= numbers.Length - 1; i++)
//{
//    Console.WriteLine(i);
//}

//for  (int i = 0; i <= numbers.Length -1; i++)
//{
//    numbers[i] = numbers[i] * 2;
//    Console.WriteLine(numbers[i]);
//}


//int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9, }, { 10, 11, 12 } };
//int rows = mas.GetUpperBound(0) + 1;
//int column = mas.Length / rows;
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < column; j++)
//    {
//        Console.WriteLine($"{mas[i, j]} \t");
//    }
//    Console.WriteLine();
//}

//int[,] matrix = { { 9, 2, 5 }, { 10, 24, 6 }, { 7, 12, 9, }, { 8, 2, 12 } };
//int rows = matrix.GetLength(0); 
//int cols = matrix.GetLength(1);
//int sum = 0;
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        Console.Write(matrix[i, j] + "\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine(" ");

////Сумма элемента массива
//int summ = 0;
//foreach (int n in matrix)
//{
//    summ += n;
//}
//Console.WriteLine(summ);

//// Количество положительный чисел в массиве
//int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
//int result = 0;
//foreach(int n in numbers)
//{
//    if (n > 0)
//    {
//        result++;
//    }
//}
//Console.WriteLine($"Число элементов больше нуля: {result}");


////Задача 4. Перебор и вывод массива
//int[,] array2 = new int[3, 4];
//Random rand = new Random();
//// Заполнение массива случайными числами и вывод
//for (int i = 0; i < array2.GetLength(0); i++)
//{
//    for (int j = 0; j < array2.GetLength(1); j++)
//    {
//        array2[i, j] = rand.Next(1, 101); // Числа от 1 до 100
//        Console.Write(array2[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

