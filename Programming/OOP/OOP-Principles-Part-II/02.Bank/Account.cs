namespace _02.Bank
{
    using System;
    using System.Reflection;
    using System.Text;

    public abstract class Account : IDepositable
    {
        public Customer Customer { get; protected set; }
        public decimal Balance { get; protected set; }
        public decimal MonthlyInterestRate { get; protected set; }

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = interestRate;
        }

        public virtual decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                return 0M;
            }

            return numberOfMonths * this.MonthlyInterestRate;
        }

        public decimal DepositMoney(decimal sum)
        {
            this.Balance += sum;
            return this.Balance;
        }

        public override string ToString()
        {
            StringBuilder content = new StringBuilder();
            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(this) != null)
                {
                    if (!property.PropertyType.IsGenericType)
                    {
                        content.AppendLine(property.Name + ": " + property.GetValue(this));
                    }
                }
            }

            return content.ToString().Trim();
        }
    }
}
