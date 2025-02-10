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


var students = new List<(string Name, string Subject)> {
("Alice","Math"),
("Bob","Math"),
("Charlie","Physics"),
("Alice","Physics")
};

var groupBySubject = students.GroupBy(n => n.Subject);

foreach (var group in groupBySubject)
{
    Console.WriteLine($"Subject: {group.Key}");
    foreach (var student in group)
    {
        Console.WriteLine($" - {student.Name}");
    }
}



//List<User> users = new List<User>
//{
//    new User { FirstName = "Mansur", LastName = "Azizov", Age = 20, Email = "man5558@gmail.com", Password = "m123" },
//    new User { FirstName = "Aziz", LastName = "Samadov", Age = 22, Email = "rustam123@gmail.com", Password = "r123" },
//    new User { FirstName = "Asad", LastName = "Bozorov", Age = 12, Email = "asad456@gmail.com", Password = "a123" },
//    new User { FirstName = "Mustaf", LastName = "Boboev", Age = 25, Email = "mustaf789@gmail.com", Password = "m456" },
//    new User { FirstName = "Rashid", LastName = "Mirsaidov", Age = 30, Email = "rashid321@gmail.com", Password = "r789" }

//};

//// Пользователи старше 20 лет
//var usersAbove20 = users.Where(x => x.Age > 20);
//Console.WriteLine("\nПользователи старше 20 лет:");
//foreach (var user in usersAbove20)
//   Console.WriteLine($"{user.FirstName} {user.LastName}, возраст: {user.Age}");


//// Отсортировка пользователей по имени и фамилии
//var orderByFirstLast = users.OrderBy(first => first.FirstName).ThenBy(last => last.LastName);
//Console.WriteLine("\nОтсортированные пользователи по имени: ");
//foreach(var user in orderByFirstLast)
//   Console.WriteLine($"{user.FirstName} {user.LastName}");


//// Вывести всех пользователей у которых имя начинается с буквы А
//var orderByToLastA = users.Where(last => last.FirstName.StartsWith("A"));
//Console.WriteLine("\nИмя ползователей у которых имя начинается на А: ");
//foreach (var user in orderByToLastA)
//    Console.WriteLine($"{user.FirstName}");