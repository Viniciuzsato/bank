using System;
using Course.Entites;
using Transactions.Entites;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(0446, "Vinicius Sato", 500.0);
            Account acc2 = new SavingsAccount(1008, "Natalia", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
