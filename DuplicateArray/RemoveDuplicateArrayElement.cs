using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateArray
{
    class RemoveDuplicateArrayElement
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "orange", "apple", "mango", "banana" };

            // Use HashSet to remove duplicates
            var uniqueFruits = new HashSet<string>(fruits);

            // Convert HashSet back to array if needed
            string[] uniqueFruitsArray = uniqueFruits.ToArray();

            // Print unique fruits
            Console.WriteLine("Unique fruits:");
            foreach (var fruit in uniqueFruitsArray)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
