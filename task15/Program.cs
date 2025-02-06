
List<int> array = new List<int> { 5, 2, 3, 5, 6 };
List<int> result = new List<int>();
foreach (var item in array)
{

    if (!result.Contains(item))
    {
        result.Add(item);
    }
}
//int element = array[0];
//foreach (var i in result)
//{
//    if (i <= element)
//    {
//        element = i;
//    }

//}
//Console.WriteLine(element);
result.Sort();
Console.WriteLine(string.Join(", ", result));
