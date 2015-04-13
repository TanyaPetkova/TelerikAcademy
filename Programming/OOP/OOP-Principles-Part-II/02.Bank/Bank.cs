namespace _02.Bank
{
    using System.Collections.Generic;

    public class Bank
    {
        public List<Account> Accounts { get; private set; }

        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        public void AddAccounts(params Account[] accounts)
        {
            foreach (var account in accounts)
            {
                this.Accounts.Add(account);
            }
        }

        public void RemoveAccount(Account account)
        {
            this.Accounts.Remove(account);
        }
    }
}
