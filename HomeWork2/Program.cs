using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
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
