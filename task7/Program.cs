using System.Globalization;
using System.Text;

//Console.WriteLine("Введите слово: ");
//string input = Console.ReadLine() ?? "";

//StringBuilder result = new StringBuilder();
//string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";


//foreach (char c in input)
//{
//    if (vowels.Contains(c))
//    {
//        result.Append('*');
//    }
//    else if (c == ' ')
//    {
//        result.Append('-');
//    }
//    else
//    {
//        result.Append(c);
//    }
//}

//int wordcount = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
//string longesword = "";
//foreach (string word in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
//{
//    if (word.Length > longesword.Length)
//    {
//        longesword = word;
//    }
//}

//int digcount = 0;
//foreach (char n in input)
//{
//    if (char.IsDigit(n))
//    {
//        digcount++;
//    }
//}
//Console.WriteLine(result.ToString() + "\n");
//Console.WriteLine("Количество слов: " + wordcount);
//Console.WriteLine("Самое длинное слово: " + longesword);
//Console.WriteLine("Количество цифр: " + digcount);
//string result = input.Replace('а', '*')
//                     .Replace('о', '*')
//                     .Replace('у', '*')
//                     .Replace('е', '*')
//                     .Replace('ё', '*')
//                     .Replace('э', '*')
//                     .Replace('и', '*')
//                     .Replace('ю', '*')
//                     .Replace('я', '*')
//                     .Replace('ы', '*')
//                     .Replace(' ', '-');
//Console.WriteLine(result.ToString());


CultureInfo russianCulture = new CultureInfo("ru-RU");
DateTime dateTime = DateTime.Now;
string dayOfWeek = dateTime.ToString("dddd", russianCulture);
dayOfWeek = char.ToUpper(dayOfWeek[0]) + dayOfWeek.Substring(1);
Console.WriteLine($"Сегодня: {dateTime.ToString("dd.MM.yyyy 'года'")}");
Console.WriteLine($"День недели: {dayOfWeek}");






//int length = 1000000;
//StringBuilder sb = new StringBuilder(length);
//for (int i = 0; i < length; i++)
//{
//    sb.Append('A');
//}
//string result = sb.ToString();
//Console.WriteLine("Длина созданной строки: " + result.Length);

