using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Supports High Resolution StopWatch? {0}", Stopwatch.IsHighResolution);
            Console.WriteLine("Stopwatch Frequency? {0}", Stopwatch.Frequency);

            // Pause
            Console.ReadLine();

        }
    }
}
