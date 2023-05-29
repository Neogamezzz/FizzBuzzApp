using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number or press 't' for exit");
                string val = Console.ReadLine();

                if (val.ToLower() == "t")
                {
                    Environment.Exit(0);
                }

                if (!int.TryParse(val, out int userNumber))
                {
                    Console.WriteLine("Invalid value. Try again or press 't' for exit");
                    continue;
                }

                FizzBuzz fizzBuzz = new FizzBuzz();
                fizzBuzz.StartGame(userNumber);
            }
        }
    }
}