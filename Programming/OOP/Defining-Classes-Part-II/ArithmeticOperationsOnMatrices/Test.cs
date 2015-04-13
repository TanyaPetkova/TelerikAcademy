namespace ArithmeticOperationsOnMatrices
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        private static int InputData(string message)
        {
            int dimension;
            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out dimension))
            {
                Console.Write("Invalid input. Enter a positve integer number: ");
            }

            return dimension;
        }

        private static Matrix<int> FillingMatrix(string message)
        {
            Console.WriteLine(message);
            int rowsCount = InputData("Enter the number of the rows: ");
            int columnsCount = InputData("Enter the number of the columns: ");

            Matrix<int> matrix = new Matrix<int>(rowsCount, columnsCount);

            //Enter the matrix elements
            for (int row = 0; row < rowsCount; row++)
            {
                string[] separators = new string[] { " ", ", ", "\t" };
                string currentRow = Console.ReadLine();
                string[] numbersAsStrings = currentRow.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int column = 0; column < numbersAsStrings.Length; column++)
                {
                    if (column < columnsCount)
                    {
                        matrix[row, column] = int.Parse(numbersAsStrings[column]);
                    }
                }
            }

            return matrix;
        }

        static void Main()
        {
            Matrix<int> firstMatrix = FillingMatrix("Data for the first matrix");
            Matrix<int> secondMatrix = FillingMatrix("Data for the second matrix");

            Console.WriteLine("First matrix: ");
            Console.WriteLine(firstMatrix);

            Console.WriteLine("Second matrix:");
            Console.WriteLine(secondMatrix);

            while (true)
            {
                Console.WriteLine("Choose the number of the desired task: ");
                Console.WriteLine("1. Adding of two matrices");
                Console.WriteLine("2. Subtracting of two matrices");
                Console.WriteLine("3. Multiplying of two matrices");
                Console.WriteLine("4. Exit");

                uint choice = 0;

                while (!uint.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2 && choice != 3 && choice != 4))
                {
                    Console.WriteLine("Invalid input. Enter a number between 1 and 4: ");
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Adding:");
                        Console.WriteLine((firstMatrix + secondMatrix).ToString());
                        break;
                    case 2:
                        Console.WriteLine("Subtracting:");
                        Console.WriteLine((firstMatrix - secondMatrix).ToString());
                        break;
                    case 3:
                        Console.WriteLine("Multiplying:");
                        Console.WriteLine((firstMatrix * secondMatrix).ToString());
                        break;
                    case 4: Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
