//Calculator calculator = new Calculator();
//calculator.Add(2, 3); // 1
//calculator.Add(3, 4, 4); // 2
//calculator.Add(4, 5, 5, 5); // 3
//calculator.Add(5.5, 6.5);// 4
//int val = 2;
//calculator.Increment(ref val); 
//calculator.Increment(val);

//Circle circle = new Circle();
//circle.Radius = 3;
//circle.CalculateArea();
//circle.CalculateCircumference();

BankAccount bankaccount = new BankAccount();
bankaccount.AccountNumber = 17681393;
bankaccount.AccountHolder = "Mirsaidov";
bankaccount.Balance = 15000;

bankaccount.Deposit(5000);
bankaccount.Withdraw(5000);
bankaccount.GetAccountInfo();