List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = 0;
foreach (var number in numbers)
{
    sum += number;
}
Console.WriteLine(sum);


Dictionary<string, int> dict = new Dictionary<string, int>
{
    {"Mirsaidov", 100 },
    {"Radzhabov", 98 },
    {"Bozorov", 90 }
};
Console.WriteLine(string.Join(", \n", dict.Select(x => $"Студент: {x.Key} Балл: {x.Value}")));

