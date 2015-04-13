namespace _02.Bank
{
    using System;

    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public decimal WithDraw(decimal sum)
        {
            if (this.Balance - sum > 0)
            {
                this.Balance -= sum;
            }
            else
            {
                Console.WriteLine("There is not enought money available.");
            }

            return this.Balance;
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                Console.WriteLine("There is not interest, if the balance is positive and less than 1000");
                return 0M;
            }
            else
            {
                return base.CalculateInterestAmount(numberOfMonths);
            }
        }
    }
}
