//static async Task<string> GetHttpContentAsync(string url)
//{
//    using HttpClient client = new HttpClient();
//    return await client.GetStringAsync(url);
//}

//string content = await
//GetHttpContentAsync("https://jsonplaceholder.typicode.com/posts");
//Console.WriteLine(content);



//GetSum();

//static async Task GetSum()
//{
//    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//    int sum = 0;
//    for (int i = 0; i <= array.Length - 1; i++)
//    {
//        sum += array[i];
//    }
//    Console.WriteLine($"Сумма элемента массива: {sum}");
//}

//static async Task GetSum()
//{
//    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//    int sum = 0;
//    for (int i = 0; i <= array.Length - 1; i++)
//    {
//        sum += array[i];
//    }
//    Console.WriteLine($"Сумма элемента массива: {sum}");
//}






//int result = 237;
//int a = result % 10;
//result -= a;
//result /= 10;
//result += a + 100;

//Console.WriteLine("Исходное число x: " + result);


//Console.WriteLine("Введите x: ");
//int x = Convert.ToInt32(Console.ReadLine());

//double y;
//double z;

//if (x > 4) 
//{ 
//    y = (-0.5 * x) + 2; 
//    Console.WriteLine($"x больше 4: {y}"); 
//}

//if (x <= 4) 
//{
//    z = Math.Pow(x - 4, 2); 
//    Console.WriteLine($"x меньше или равно 4: {z}");
//}

GetArray();

static void GetArray()
{
    int[] array = new int[10];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(30);
        Console.WriteLine(array[i]);
    }
}