﻿using System;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Logical Programs-----");

            // Fibonnaci Series
            /*Fibonacci_Series fs = new Fibonacci_Series();

            fs.FibonacciSeries();*/

            // Perfect Number

            /*Perfect_Number pn = new Perfect_Number();

            pn.PerfectNumber();*/

            // Prime Number

            /*
             * Prime_Number prime = new Prime_Number();
             * prime.PrimeNumber();
            */

            // Reverse a number

            /*
             * Reverse_Number rn = new Reverse_Number();
             * rn.ReverseNumber();
            */

            // Coupon Numbers

            Coupon_Numbers coupon = new Coupon_Numbers();

            coupon.CouponNumbers();

        }
    }
}