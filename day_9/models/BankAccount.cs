using System;

public class BankAccount
{
	public int AccountNumber;
	public string AccountHolder;
	public decimal Balance;

	

	public BankAccount()
	{
        Balance = 0;
    }

	public void Deposit(decimal amount)
	{
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Поступило {amount}. Текущий баланс: {Balance}.");
        }
        else
        {
            Console.WriteLine("Сумма должна быть положительным.");
        }
    }

	public void Withdraw(decimal amount)
	{
        if (amount > 0)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount}. Текущий баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
        else
        {
            Console.WriteLine("Сумма должна быть положительным.");
        }
    }

	public void GetAccountInfo()
	{
        Console.WriteLine($"Счет: {AccountNumber}, Владелец: {AccountHolder}, Баланс: {Balance}.");
	}
}
