List<int> array = new List<int> { 5, 2, 3, 5, 6 };

var querySyntax = from n in array
                  where n % 2 == 0
                  select n;

var methodSyntax = array.Where(n => n % 2 == 0);


Console.WriteLine($"Четные числа (Query Syntax): ");
foreach (var n in querySyntax)
{
    Console.WriteLine(n);
}

Console.WriteLine("Чётные числа (Method Syntax): ");
foreach (var n in methodSyntax)
{
    Console.WriteLine(n);
}
