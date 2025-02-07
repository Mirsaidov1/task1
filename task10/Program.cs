
// Задание_1
// Создайте список целых чисел и заполните его числами от 1 до 10
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine(string.Join(", ", numbers));
// Добавьте в список числа 11 и 12.
numbers.Add(11);
numbers.Add(12);
Console.WriteLine("Список после добавления: " + string.Join(", ", numbers));
// Удалите из списка все четные числа.
numbers.RemoveAll(x => x % 2 == 0);
Console.WriteLine("Список после удаления чётных чисел: " + string.Join(", ", numbers));
// Найдите первое число, которое больше 5.
int one = numbers.Find(x => x > 5);
Console.WriteLine("Первое число больше 5: " + one);
// Разверните список в обратном порядке.
numbers.Reverse();
Console.WriteLine("Список в обратном порядке: " + string.Join(", ", numbers)+"\n");

// Задание_2
// Создайте словарь, где ключи — это названия стран, а значения — их столицы. 
var dict = new Dictionary<string, string> { { "Россия", "Москва" }, { "Франция", "Париж" }, { "Германия", "Берлин" } };
// Добавьте в словарь еще три страны с их столицами
dict.Add("Узбекистан","Ташкент");
dict.Add("Афганистан","Кабул");
dict.Add("Пакистан","Исламабад");
// Проверьте, есть ли в словаре страна "Италия". Если ее нет, добавьте пару "Италия" - "Рим".
Console.WriteLine(dict.ContainsKey("Италия")); // False
dict.Add("Италия", "Рим");
Console.WriteLine("Словарь после добавления: "+string.Join(", ", dict.Select(x => $"{x.Key}: {x.Value}")));
// Удалите любую страну из словаря
if(dict.Remove("Франция", out var removedValue))
{
    Console.WriteLine($"Удаленный элемент: {removedValue}");
}
Console.WriteLine(string.Join(", ", dict.Select(x => $"{x.Key}: {x.Value}")));
// Попробуйте получить значение для ключа "Германия" с использованием TryGetValue.
if (dict.TryGetValue("Германия", out var value))
{
    Console.WriteLine($"Столица Германии: {value}");
}
else
    Console.WriteLine("Key not found");

