using System;

namespace DuplicateArray
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.Write("Enter Number is Even");
            }
            else
            {
                Console.Write("Enter Number is Odd");
            }
        }
    }
}
