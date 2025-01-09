// 1. Сумма всех чисел массива
int GetArray(int [] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        sum += item;
    }
    return sum;
}
int[] myarray = { 6, 2, 4, 5, 6, 8, 9, 0 };
int result = GetArray(myarray);
Console.WriteLine(result);

// 2. Наибольшое число в массиве
int BadArray(int[] array1)
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
int[] myarray2 = { 6, 2, 4, 5, 6, 8, 9, 0 };
int result1 = BadArray(myarray2);
Console.WriteLine(result1);