using System;
using System.Linq;

namespace Monitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to start the timer");
            Console.ReadLine();
            Recorder.Start();

            int[] largeArrayOfInts = Enumerable.Range(1, 10000).ToArray();

            //Console.Write($"count{largeArrayOfInts.Length}");

            Console.Write("Press ENTER to stop the timer");
            Console.ReadLine();
            Recorder.Stop();
            Console.ReadLine();
        }
    }
}
