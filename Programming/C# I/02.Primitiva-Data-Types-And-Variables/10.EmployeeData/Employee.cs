//A marketing firm wants to keep record of its employees. Each record would have the following characteristics – 
//first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
//Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

class Employee
{
    static void Main()
    {
        Console.Write("Enter emopoyee's first name: ");
        string firstName = Console.ReadLine();
      
        Console.Write("Enter employee's family name: ");
        string familyName = Console.ReadLine();

        Console.Write("Enter employee's age: ");
        byte age;

        while (!byte.TryParse(Console.ReadLine(), out age) || (age < 1 || age > 120))
        {
            Console.Write("Invalid input. Enter employee's age: ");
        }

        Console.Write("Enter employee's gender: ");
        char gender = char.Parse(Console.ReadLine());

        Console.Write("Enter employee's ID number: ");
        string idNumber = Console.ReadLine();

        Console.Write("Enter employee's unique number: ");
        uint uniqueEnployeeNumber;

        while (!uint.TryParse(Console.ReadLine(), out uniqueEnployeeNumber) || (uniqueEnployeeNumber < 27560000 || uniqueEnployeeNumber > 27569999))
        {
            Console.Write("Invalid input. Enter employee's unique name: ");
        }

        Console.WriteLine("{0} {1} is {2} years old with gender {3}, ID number {4} and unique employee number {5}", firstName, familyName, age, gender, idNumber, uniqueEnployeeNumber);
    }

}

