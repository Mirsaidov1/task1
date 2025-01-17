// 1. Проверка на палиндром в числовом массиве
int[] zd1 = { 121, 234, 1221, 456, 989 };
foreach (int i in zd1)
{
    bool isPalindrome = true;
    string str = i.ToString();
    int length = str.Length;
    for (int j = 0; j < length / 2; j++)
    {
        if (str[j] != str[length - j - 1])
        {
            isPalindrome = false;
            break;
        }
    }
    Console.WriteLine($"{i}: {isPalindrome}");
}
// 2. Количество четных и не четных чисел в одномерном массиве
int[] array = { 121, 234, 1221, 456, 989 };
int a = 0;
int a1 = 0;
foreach (var item in array)
{
    if (item % 2 == 0)
    {
        a++;
    }
    else if (item % 2 > 0)
    {
        a1++;
    }
    Console.WriteLine(item);
}
Console.WriteLine($"Количество четных чисел:{a}");
Console.WriteLine($"Количество не четных чисел:{a1}\n");
// Количество четных и не четных чисел в многомерном массиве
int[,] arr1 = { { 1, 2, 3 }, { 4, 3, 5 }, { 5, 4, 6 } };
int count = 0;
int countt = 0;
foreach (var i in arr1)
{
    if (i % 2 == 0)
    {
        count++;
    }
    else if (i % 2 > 0)
    {
        countt++;
    }
    Console.WriteLine(i);
}
Console.WriteLine($"Количество четных чисел: {count}");
Console.WriteLine($"Количество не четных чисел: {countt}\n");
// 3. MIN и MAX в многомерном массиве ds
int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int max = array1[0, 0];
int min = array1[0, 0];
foreach (int item in array1)
{
    if (item > max)
    {
        max = item;
    }
    else if (item < min)
    {
        min = item;
    }
    Console.Write(item + "\n");
}
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}\n");











