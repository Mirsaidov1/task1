

//Thread currentThread = Thread.CurrentThread;
//currentThread.Name = "asda";
//Console.WriteLine($"{currentThread.Name}");


//Thread thread = new Thread(PrintNumbers);
//thread.Start();
//Console.WriteLine("Основной поток завершён.");

//void PrintNumbers(object state)
//{
//    for (int i = 1; i <= 5; i++)
//    {
//        Console.WriteLine($"Число: {i}");
//        Thread.Sleep(1000);
//    }
//}


//Parallel.For(0, 10, i =>
//{
//    Console.WriteLine($"Итерация: {i}, Выполнение потока {Task.CurrentId}");
//});


//var task1 = Task.Run(() => Console.WriteLine("1 поток завершён"));
//await Task.Delay(1000);
//var task2 = Task.Run(() => Console.WriteLine("2 поток завершён"));
//await Task.Delay(1000);
//var task3 = Task.Run(() => Console.WriteLine("3 поток завершён"));
//await Task.Delay(1000);
//var task4 = Task.Run(() => Console.WriteLine("4 поток завершён"));
//await Task.Delay(1000);
//var task5 = Task.Run(() => Console.WriteLine("5 поток завершён"));
//await Task.Delay(1000);

var tasks = new Task[5];
for (int i = 1; i <= 5; i++)
{
    int taskId = i + 1;
    tasks[i] = Task.Run(async () =>
    {
        await Task.Delay(1000);
        Console.WriteLine($"Поток {taskId} завершён");
    });
    
}
await tasks;
Console.WriteLine($"{tasks}");




//for (int i = 0; i < 5; i++)
//{
//    int threadNumber = i + 1;
//    Thread thread = new Thread(() => PrintNumbers(threadNumber));
//    thread.Start();
//    Console.WriteLine($"{threadNumber} поток завершён.");
//    Thread.Sleep(1000);
//}
    

//    static void PrintNumbers(int threadNumber)
//{
//    for (int i = 1; i <= 1; i++)
//    {
//        Thread.Sleep(1000);
//    }
//}