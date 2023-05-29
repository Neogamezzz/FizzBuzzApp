using System;

namespace FizzBuzzApp
{
    internal class FizzBuzz
    {
        internal void StartGame(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine($"Your number must be divisible by 3 or 5 without a remainder. You entered the number {number}");
            }
        }
    }
}
