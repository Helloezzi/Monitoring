using System;
using System.Linq;

namespace Monitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Press ENTER to start the timer");
            Console.ReadLine();
            Recorder.Start();

            int[] largeArrayOfInts = Enumerable.Range(1, 10000).ToArray();

            Console.Write("Press ENTER to stop the timer");
            Console.ReadLine();
            Recorder.Stop();
            Console.ReadLine();
            */

            int[] numbers = Enumerable.Range(1, 10000).ToArray();
            Recorder.Start();
            Console.WriteLine("using string");

            string s = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                s += numbers[i] + ", ";                
            }
            Recorder.Stop();

            Recorder.Start();
            Console.WriteLine("using StringBuilder");
            var builder = new System.Text.StringBuilder();
            for (int i= 0; i < numbers.Length; i++)
            {
                builder.Append(numbers[i]);
                builder.Append(", ");
            }
            Recorder.Stop();
            Console.ReadLine();
        }
    }
}
