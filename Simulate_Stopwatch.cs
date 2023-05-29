using System;
using System.Diagnostics;

namespace Logical_Programs
{
    internal class Simulate_Stopwatch
    {
        public void SimulateStopwatch()
        {
            Stopwatch sw = Stopwatch.StartNew();

            Console.WriteLine("Enter start time: ");
            sw.Start();
            int start_time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end time: ");
            int end_time = Convert.ToInt32(Console.ReadLine());

            for(int i = start_time; i < end_time; i++)
            {
                Console.WriteLine(i);
            }

            sw.Stop();
            Console.WriteLine("Elapsed Time: " + sw.ElapsedMilliseconds);
        }
    }
}
