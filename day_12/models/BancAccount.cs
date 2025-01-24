using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_12.models
{
    public class BancAccount(string accountNumber, decimal initialBalance)
    {
        private decimal balance; // Приватное поле, доступно только внутри класса.

        public string AccountNumber { get; private set; } // Только чтение извне


        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма дожна быть больше нуля.");
            }
            balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("Недостаточно средств на счете.");
            }
            balance -= amount;
        }
    }
}
