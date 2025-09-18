using System;
using Account.Entities;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
            // UPCASTING
            Entities.Account acc1 = bacc;
            Entities.Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Entities.Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            // BusinessAccount acc5 = (BusinessAccount)acc3; // InvalidCastException
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            else if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            // Another way to downcast
            if (acc3 is SavingsAccount sa)
            {
                sa.UpdateBalance();
                Console.WriteLine("Update!");
            }
            Console.WriteLine(bacc.Balance);
        }
    }

}