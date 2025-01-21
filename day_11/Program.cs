//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int sum = 0;
//foreach (var number in numbers)
//{
//    sum += number;
//}
//Console.WriteLine(sum);
//Dictionary<string, int> dict = new Dictionary<string, int>
//{
//    {"Mirsaidov", 100 },
//    {"Radzhabov", 98 },
//    {"Bozorov", 90 }
//};
//Console.WriteLine(string.Join(", \n", dict.Select(x => $"Студент: {x.Key} Балл: {x.Value}")));
using day_11;
using day_11.models;

//Animal dog = new Dog();
//Smallcat cat = new Smallcat();
//dog.Eat();
//dog.Speak();
//cat.Speak();

Person person = new Person();
person.Name = "Mansur";
person.Age = 20;
person.Introduce();

Student student = new Student();
student.Grade = 100;
student.Name = "M";
student.Age = 20;
student.Work();
student.PrintInfo();


Teacher teacher = new Teacher();
teacher.Name = "t";
teacher.Age = 20;
teacher.Subject = "PHP";
teacher.Work();
teacher.PrintInfo();

//IFlyable bird =  new Bird();
//bird.Fly();

