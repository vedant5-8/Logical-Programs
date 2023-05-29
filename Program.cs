using System;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Logical Programs-----");

            while (true)
            {
                Console.WriteLine("\nChoose an option");
                Console.WriteLine("1. Fibonnaci Series");
                Console.WriteLine("2. Perfect Number");
                Console.WriteLine("3. Prime Number");
                Console.WriteLine("4. Reverse Number");
                Console.WriteLine("5. Coupon Number");
                Console.WriteLine("6. Simulate Stopwatch");
                Console.WriteLine("7. Exit");

                Console.Write("=> ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Fibonacci_Series fs = new Fibonacci_Series();
                        fs.FibonacciSeries();
                        break;
                    case 2:
                        Perfect_Number perfect = new Perfect_Number();
                        perfect.PerfectNumber();
                        break;
                    case 3:
                        Prime_Number prime = new Prime_Number();
                        prime.PrimeNumber();
                        break;
                    case 4:
                        Reverse_Number reverse = new Reverse_Number();
                        reverse.ReverseNumber();
                        break;
                    case 5:
                        Coupon_Numbers coupon = new Coupon_Numbers();
                        coupon.CouponNumbers();
                        break;
                    case 6:
                        Simulate_Stopwatch stopwatch = new Simulate_Stopwatch();
                        stopwatch.SimulateStopwatch();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter valid option.");
                        break;
                }
            }

        }
    }
}