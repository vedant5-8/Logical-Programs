using System;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Logical Programs-----");

            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Fibonnaci Series");
            Console.WriteLine("2. Perfect Number");
            Console.WriteLine("3. Prime Number");
            Console.WriteLine("4. Reverse Number");
            Console.WriteLine("5. Coupon Number");
            Console.WriteLine("6. Simulate Stopwatch");
            Console.WriteLine("7. Exit");

            Console.WriteLine("=> ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Fibonacci_Series fs = new Fibonacci_Series();
                    fs.FibonacciSeries();
                    break;
                default:
                    Console.WriteLine("Enter valid option.");
                    break;
            }

        }
    }
}