namespace _20.InfiniteConvergentSeries
{
    using System;

    public delegate double MyDelegate(int number, double precission);

    class InfiniteConvergentSeries
    {
        static double SumFirstSequence(int number, double precision)
        {
            double sum = 1;
            double divisor = 1;
            int counter = 1;

            while (true)
            {
                if (counter > number) break;
                divisor = divisor * 2;
                sum += 1 / divisor;
                counter++;
            }

            Console.WriteLine((int)(sum * Math.Pow(10, precision)) / Math.Pow(10, precision));
            return sum;
        }

        static double SumSecondSequence(int number, double precision)
        {
            int counter = 1;
            double sum = 1;
            int divisor = 1;

            while (true)
            {
                counter++;
                if (counter > number) break;
                sum += 1 / Factorial(++divisor);
            }

            Console.WriteLine((int)(sum * Math.Pow(10, precision)) / Math.Pow(10, precision));
            return sum;
        }

        static double SumThirdSequence(int number, double precision)
        {
            int counter = 1;
            double sum = 1;
            double divisor = 1;

            while (true)
            {
                counter++;
                if (counter > number) break;
                divisor = Math.Pow(-1, counter) * Math.Abs(divisor * 2);
                sum += 1 / divisor;
            }

            Console.WriteLine((int)(sum * Math.Pow(10, precision)) / Math.Pow(10, precision));
            return sum;
        }

        static double Factorial(int number)
        {
            double product = 1;

            for (int i = 1; i <= number; i++)
            {
                product *= i;
            }

            return product;
        }

        public static void Calculate(int number, double precision)
        {
            MyDelegate d = new MyDelegate(SumFirstSequence);
            d += new MyDelegate(SumSecondSequence);
            d += new MyDelegate(SumThirdSequence);
            d(number, precision);
        }

        static void Main()
        {
            Calculate(10, 2);
        }
    }
}
