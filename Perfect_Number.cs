using System;
using System.Threading.Channels;

namespace Logical_Programs
{
    internal class Perfect_Number
    {
        public void PerfectNumber()
        {
            int n, sum = 0;

            Console.WriteLine("\nPerfect Number");
            Console.WriteLine("Check whether the given number is perfect number or not.");

            Console.WriteLine("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The positive divisors: ");
            for (int i = 1; i < n; i++)
            {
                if(n % i == 0)
                {
                    sum += i;
                    Console.Write("{0} ", i);
                }
            }

            if (sum == n)
            {
                Console.WriteLine("\n{0} is a perfect number.", n);
            }
            else
            {
                Console.WriteLine("\n{0} is not a perfect number.", n);
            }
        }
    }
}
