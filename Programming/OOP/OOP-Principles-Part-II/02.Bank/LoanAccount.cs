namespace _02.Bank
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (this.Customer == Customer.Individual)
            {
                return base.CalculateInterestAmount(numberOfMonths - 3);
            }
            else
            {
                return base.CalculateInterestAmount(numberOfMonths - 2);
            }
        }
    }
}
