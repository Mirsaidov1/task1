// ДЗ_День_7
using System.Text;

Console.WriteLine("Введите слово: ");
string input = Convert.ToString(Console.ReadLine());

StringBuilder result = new StringBuilder();
string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
foreach (char c in input)
{
    if (vowels.Contains(c))
    {
        result.Append('*');
    }
    else if (c == ' ')
    {
        result.Append('-');
    }
    else
        result.Append(c);
}
int wordcount = input.Length;

string longesword = "";
foreach (string word in input)
{
    if (word.Length > longesword.Length)
    {
        longesword = word;
    }
}

int digcount = 0;
foreach (char n in input)
{
    if (char.IsDigit(n))
    {
        digcount++;
    }
}

Console.WriteLine(result + "\n");
Console.WriteLine("Количество слов: " + wordcount);
Console.WriteLine("Самое длинное слово: " + longesword);
Console.WriteLine("Количество цифр: " + digcount);
// string result = input.Replace('а','*')
//                      .Replace('о','*')
//                      .Replace('у','*')
//                      .Replace('е','*')
//                      .Replace('ё','*')
//                      .Replace('э','*')
//                      .Replace('и','*')
//                      .Replace('ю','*')
//                      .Replace('я','*')
//                      .Replace('ы','*')
//                      .Replace(' ','-');
// System.Console.WriteLine(result);

