using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Prime_Number
    {
        public void PrimeNumber()
        {
            int n;
            bool flag = false;

            Console.WriteLine("\n-----Check Prime Number-----");
            Console.WriteLine("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i <= n / 2; i++)
            {
                if(n % i == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("{0} is a prime number.", n);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number.", n);
            }
        }
    }
}
