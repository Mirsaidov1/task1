// 1. Сумма всех чисел массива
int SumArray(int [] array)
{
    int sum = 0;
    //foreach (var item in array)
    //{
    //    sum += item;
    //}
    //return sum;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        sum += array[i];
    }
    return sum;
}
int[] myarray = { 6, 2, 4, 5, 6, 8, 9, 0 };
int result = SumArray(myarray);
Console.WriteLine(result); // 40
int[] myarray1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int result1 = SumArray(myarray1);
Console.WriteLine(result1); // 55
// 2. Наибольшое число в массиве
int MaxValueInArray(ref int[] array1)
{
    int max = array1[0];
    foreach (var item in array1)
    {
        if (item > max)
        {
            max = item;
        }
    }
    return max;
}
int[] myarray2 = { 6, 2, 4, 5, 6, 8, 20, 0 };
int result2 = MaxValueInArray(ref myarray2);
Console.WriteLine(result2); // 20
int[] myarray3 = { 1, 2, 3, 4, 5, 6, 7, 9, 30 };
int result3 = MaxValueInArray(ref myarray3);
Console.WriteLine(result3); // 30
// 3. Вычисляет сумму чисел от 1 до N 
int sum = 0;
int SumInArray(int n)
{
    if (n > 0)
    {
        sum += n;
        n--;
        SumInArray(n);
    }
    return sum;
}
Console.WriteLine(SumInArray(10));
