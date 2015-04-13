namespace _02.Bank
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (this.Customer == Customer.Individual)
            {
                return base.CalculateInterestAmount(numberOfMonths - 6);
            }
            else 
            {
                if (numberOfMonths <= 12)
                {
                    Console.WriteLine("There is one half interest for the first 12 months if the account is held by company customer.");
                    return base.CalculateInterestAmount(numberOfMonths) / 2;
                }
                else
                {
                    return base.CalculateInterestAmount(numberOfMonths);
                }               
            }
        }
    }
}
