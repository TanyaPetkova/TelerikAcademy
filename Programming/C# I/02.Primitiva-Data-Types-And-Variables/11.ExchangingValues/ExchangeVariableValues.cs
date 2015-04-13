namespace ExchangeVariableValues
{
    using System;

    /// <summary>
    /// Problem 9. Exchange Variable Values
    /// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
    /// Print the variable values before and after the exchange.
    /// </summary>
    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int firstVariable = 5;
            int secondVariable = 10;

            PrintNumbers(firstVariable, secondVariable);
            SwapValues(ref firstVariable, ref secondVariable);

            // SwapPositiveValues(ref firstVariable, ref secondVariable);  
            PrintNumbers(firstVariable, secondVariable);
        }

        private static void SwapValues(ref int firstNumber, ref int secondNumber)
        {
            var temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        private static void SwapPositiveValues(ref int firstNumber, ref int secondNumber)
        {
            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;
        }

        private static void PrintNumbers(int firstNumber, int secondNumber) 
        {
            Console.WriteLine("First number = {0}, Second number = {1}", firstNumber, secondNumber);
        }
    }
}
