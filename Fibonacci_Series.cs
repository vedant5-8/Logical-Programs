using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Fibonacci_Series
    {
        public void FibonacciSeries()
        {
            Console.WriteLine("\n-----Fibonacci Series-----");
            int firstNumber = 0, secondNumber = 1, thirdNumber;

            Console.Write("Enter the number of elements you want: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(firstNumber + " ");

                thirdNumber = firstNumber + secondNumber;

                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
        }
    }
}
