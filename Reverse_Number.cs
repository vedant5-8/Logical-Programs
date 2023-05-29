using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse_Number
    {
        public void ReverseNumber()
        {
            int num;
            int reverse = 0;

            Console.WriteLine("\n-----Reverse a number-----");
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            // run loop until num becomes 0
            while (num != 0)
            {
                // get last digit from num
                int digit = num % 10;
                reverse = reverse * 10 + digit;

                // remove the last digit from num
                num /= 10;
            }

            Console.WriteLine("Reversed Number: " + reverse);
        }
    }
}
