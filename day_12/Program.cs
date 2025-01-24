using day_12.models;

//var account = new BancAccount("123456", 1000);
//Console.WriteLine("" + account.GetBalance());

//account.Deposit(500);
//Console.WriteLine("" + account.GetBalance());

//account.WithDraw(200);
//Console.WriteLine("" + account.GetBalance());

//Employee employee = new Employee();
//employee.Name = "Mansur";
//employee.IsProbationPassed = true;
//employee.GetIsProbation(1000);
//employee.GetSalary();

//Document[] document = { new PdfDocument(), new WordDocument() };

Document pdfdocument = new PdfDocument();
pdfdocument.Save();
pdfdocument.Print();
Document worddocument = new WordDocument();
worddocument.Print();
