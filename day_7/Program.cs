using System.Text;

// StringBuilder sb = new StringBuilder("Hello");
// sb.Insert(5, ",");
// sb.Append("World");
// //sb.Remove(5, 2);
// sb.Replace("World", "C#");
// Console.WriteLine(sb);

// string name = "Hellow World a";
//       // 1 
//       int length = name.Length;
//       Console.WriteLine("1: " + length);
//       // 2
//       char first = name[0];
//       char end = name[11];
//       Console.WriteLine("2: " + first + "\n" + end);
//     //   Console.WriteLine("2: " + end);
//       // 3
//       string upper = name.ToUpper();
//       string lower = name.ToLower();
//       Console.WriteLine("3: " + upper);
//       Console.WriteLine("3: " + lower);
//       // 4
//       int index = name.IndexOf('a');
//       Console.WriteLine("4: " + index);
//       //5
//       string n = name.Insert(6," -");
//       Console.WriteLine("5: " + n);
//       // палиндром
//       string one = "level";
//       bool isPolindrom(char[] one){
//         for(int i = 0; i > one.Length / 2; i++)
//             if(one[i] != one[one.Length - 1 - i])
//             return false;
//             return true;
//       }
//       char[] sym = one.ToCharArray();
//       if(isPolindrom(sym))
//       {
//             System.Console.WriteLine("Полиндром");
//       }
//       else
//       {
//         System.Console.WriteLine("Не полиндром");
//       }
      //Парсинг
        //  string input = Convert.ToString(Console.ReadLine());
        //  DateTime date1 = DateTime.Parse(input);
        //  string formattedDate = date1.ToString("dd MMMM yyyy 'года'");
        //  System.Console.WriteLine(formattedDate);
    // Использование StringBuilder
        //  StringBuilder name = new StringBuilder();
         
        //  for(int i = 1; i <= 100; i++)
        //  {
        //         name.Append(i);
        //         name.Append(", ");
        //  }
        //  System.Console.WriteLine(name);

        // ДЗ_День_7
        System.Console.WriteLine("Введите слово: ");
        string input = Convert.ToString(Console.ReadLine());

        StringBuilder result = new StringBuilder();
        string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
        foreach(char c in input) {
            if(vowels.Contains(c))
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
            if(word.Length > longesword.Length)
            {
                longesword = word;
            }
        }

        int digcount = 0;
        foreach(char n in input)
        {
            if (char.IsDigit(n))
            {
                digcount++;
            }
        }
        
        System.Console.WriteLine(result + "\n");
        System.Console.WriteLine("Количество слов: " + wordcount);
        System.Console.WriteLine("Самое длинное слово: " + longesword);
        System.Console.WriteLine("Количество цифр: " + digcount);

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



//     string result = GenerateCommaSeparatedNumbers(1, 100);
//     // Выводим результат на консоль
//     Console.WriteLine(result);


//  string GenerateCommaSeparatedNumbers(int start, int end)
// {
//     // Используем StringBuilder для эффективного построения строки
//     var sb = new System.Text.StringBuilder();

//     for (int i = start; i <= end; i++)
//     {
//         sb.Append(i); // Добавляем текущее число

//         if (i < end) // Добавляем запятую только если это не последнее число
//         {
//             sb.Append(", ");
//         }
//     }

//     return sb.ToString(); // Возвращаем получившуюся строку
// }

//   int nunber = int.Parse("123");
//   if (int.TryParse("456",out int result)){
//     Console.WriteLine($"Parse: {result}");
//   }

//   DateTime date = DateTime.Parse("2025-01-11 11:15:20");
//   Console.WriteLine(date);


// string message = "hello";
// for(int i = 0;i < message.Length;i++){
//   Console.WriteLine(message[i]);
// }

// foreach(var n in message){
//   Console.WriteLine(n);
// }



// DateTime today = DateTime.Now;
// Console.WriteLine(today);
