//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables 
//needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    public struct creditCard
    {
        public long creditCardNumber;
    }
    static void Main()
    {
        Console.Write("Enter holder's first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter holder's middle name: ");
        string middleName = Console.ReadLine();

        Console.Write("Enter holder's last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter holder's available amount of money: ");
        decimal balance;

        while (!decimal.TryParse(Console.ReadLine(), out balance))
        {
            Console.Write("Invalid input. Enter holder's available amount of money: ");
        }

        Console.Write("Enter bank name: ");
        string bankName = Console.ReadLine();

        Console.Write("Enter holder's IBAN number: ");
        string ibanNumber = Console.ReadLine();

        Console.Write("Enter BIC code: ");
        string bicCode = Console.ReadLine();

        Console.Write("Enter holder's credit card numbers: ");
        creditCard first = new creditCard();

        while (!long.TryParse(Console.ReadLine(), out first.creditCardNumber))
        {
            Console.Write("Invalid input. Enter holder's credit card numbers:  ");
        }

        Console.Write("Enter holder's credit card numbers: ");
        creditCard second = new creditCard();

        while (!long.TryParse(Console.ReadLine(), out second.creditCardNumber))
        {
            Console.Write("Invalid input. Enter holder's credit card numbers:  ");
        }

        Console.Write("Enter holder's credit card numbers: ");
        creditCard third = new creditCard();

        while (!long.TryParse(Console.ReadLine(), out third.creditCardNumber))
        {
            Console.Write("Invalid input. Enter holder's credit card numbers:  ");
        }

        Console.WriteLine("{0} {1} {2} has a balance = {3} in {4}, has IBAN number = {5}, BIC code = {6} and 3 credit cards with following numbers: {7}, {8}, {9}", firstName, middleName, lastName, balance, bankName, ibanNumber, bicCode, first.creditCardNumber, second.creditCardNumber, third.creditCardNumber
        );
    }
}
