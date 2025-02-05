// Задание 1
List<People> peoples = new List<People>
{
    new People{Name = "Bobur" },
    new People{Name = "Asadbek" },
    new People{Name = "Maks" },
    new People{Name = "Firuz" },
    new People{Name = "Rustamdzon" },
    new People{Name = "Abubakr" },
    new People{Name = "Bahovaddin" }
};

var orderLastNameB = peoples.Where(x => x.Name.StartsWith("B"));
Console.WriteLine("Люди отсортированные у которых имя начинается на В: ");
foreach (var people in orderLastNameB)
    Console.WriteLine(people.Name);

var findName = peoples.FirstOrDefault(x => x.Name.Length > 5);
if (findName != null)
{
    Console.WriteLine($"\nПервое имя, длина которого больше 5 символов: \n{findName.Name}");
}
else
{
    Console.WriteLine("Имена с длиной больше 5 символов не найдены.");
}


// Задание 2
List<Order> orders = new List<Order>
{
    new Order{OrderId = 1, CustomerName = "Rustam", Amount = 2500.10 },
    new Order{OrderId = 2, CustomerName = "Dilshod", Amount = 3999.9 },
    new Order{OrderId = 3, CustomerName = "Aziz", Amount = 1899.99 },
    new Order{OrderId = 4, CustomerName = "Asadbek", Amount = 1500.00 },
    new Order{OrderId = 5, CustomerName = "Anvar", Amount = 500.10 },
    new Order{OrderId = 6, CustomerName = "Umed", Amount = 200.80 },
    new Order{OrderId = 7, CustomerName = "Kamol", Amount = 3200.50 },
    new Order{OrderId = 8, CustomerName = "Nozim", Amount = 110.20 }
};

var highAmount = orders.Where(x => x.Amount > 500);
Console.WriteLine("\nЗаказы больше 500: ");
foreach (var order in highAmount)
    Console.WriteLine($"{order.OrderId} {order.Amount}");

var sumAmount = orders.Sum(x => x.Amount);