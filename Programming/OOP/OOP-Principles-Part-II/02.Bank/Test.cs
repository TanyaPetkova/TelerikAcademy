namespace _02.Bank
{
    using System;

    class Test
    {
        static void Main()
        {
            Bank bank = new Bank();

            Account[] accounts =
            {
                new DepositAccount(Customer.Individual, 1500, 0.5M),
                new DepositAccount(Customer.Company, 500, 0.5M),
                new LoanAccount(Customer.Individual, 1000, 1.5M),
                new LoanAccount(Customer.Company, 1000, 1.5M),
                new MortgageAccount(Customer.Individual, 2000, 1M),
                new MortgageAccount(Customer.Company, 2000, 1M)
            };

            bank.AddAccounts(accounts);

            foreach (var account in accounts)
            {
                Console.WriteLine(account.GetType().Name);
                Console.WriteLine(account);
                Console.WriteLine("Interest amount for 3 months: {0}.", account.CalculateInterestAmount(3));
                Console.WriteLine();
            }
        }
    }
}
