using System;

namespace HomeWork2
{
    public class Task1
    {
        public static void Processing()
        {
            Console.WriteLine("Enter max index of Fibonacci numbers");
            uint inputNumber;
            string inputValue = Console.ReadLine();

            if (uint.TryParse(inputValue, out inputNumber))
            {
                Console.WriteLine("Fibonacci output:");
                Fibonacci.PrintFibonacciUntilIndex(inputNumber);

                Console.WriteLine("Fibonacci with Yield output:");
                Fibonacci.PrintFibonacciUntilIndexYield(inputNumber);
            }

            Console.WriteLine("Enter number to calculate factorial");
            inputValue = Console.ReadLine();

            if (uint.TryParse(inputValue, out inputNumber))
            {
                Console.WriteLine("Factorial output:");
                Factorial.PrintFactorial(inputNumber);

                Console.WriteLine("Factorial with Yield output:");
                Factorial.PrintFactorialYield(inputNumber);
            }
            Console.Read();
        }
    }
}