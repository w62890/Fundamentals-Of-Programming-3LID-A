using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asanali Bulatov!");

            Console.WriteLine($"Sum of 2 + 2 = {2 + 2}");

            Console.WriteLine($"Sum of 4 / 2 = {4 / 2}");

            Console.WriteLine($"The result of -1 + 4 * 6 is {-1 + 4 * 6}");
            Console.WriteLine($"The result of  (35 + 5) % 7 is {(35 + 5) % 7}");
            Console.WriteLine($"The result of  14 + -4 * 6 / 11 is {14 + -4 * 6 / 11}");
            Console.WriteLine($"The result of  2 + 15 / 6 * 1 - 7 % 2 is {2 + 15 / 6 * 1 - 7 % 2}");

            Console.WriteLine("Enter 3 numbers to multipe");
            Console.WriteLine("Enter first number");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication will be {a * b * c}");



        }
    }
}
