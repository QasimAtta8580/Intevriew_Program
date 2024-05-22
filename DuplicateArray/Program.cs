using System;
using System.Collections.Generic;

namespace DuplicateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "orange", "apple", "mango", "banana" };
            // Find duplicates and their counts
            var counts = new Dictionary<string, int>();
            foreach (var fruit in fruits)
            {
                if (counts.ContainsKey(fruit))
                {
                    counts[fruit]++;
                }
                else
                {
                    counts[fruit] = 1;
                }
            }

            // Print duplicate counts
            Console.WriteLine("Duplicate string counts:");
            foreach (var entry in counts)
            {
                if (entry.Value > 1)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }
        }
    }
}
