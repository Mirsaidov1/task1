//2.Количество четных чисел
int[] array = { 121, 234, 1221, 456, 989 };
int a = 0;
foreach (var item in array)
{
    if (item % 2 == 0)
    {
        Console.WriteLine(item);
        a++;
    }
}
Console.WriteLine("Количество четных чисел:  " + a);
// 2. Количество не четных чисел
int n = 0;
foreach (var item in array)
{
    if (item % 2 > 0)
    {
        Console.WriteLine(item);
        n++;
    }
}
Console.WriteLine("Количество не четных чисел:  " + n);
// 3. MIN и MAX в многомерном массиве
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
}
Console.WriteLine(max);
Console.WriteLine(min);








int[,] arr = new int[3, 4];
Random random = new Random();


