using System;
using System.Collections;

namespace HomeWork2
{
    public class Factorial
    {
        private class FactorialCalculator : IEnumerable
        {
            public bool calculateNext;
            public IEnumerator GetEnumerator()
            {
                int number = 0;
                int currentResult = 1;
                calculateNext = true;
                while (calculateNext)
                {
                    currentResult *= ++number;
                    yield return currentResult;
                }
            }
        }

        public static void PrintFactorialYield(uint numberToCalculate)
        {
            FactorialCalculator factorialCalculator = new FactorialCalculator();
            int counter = 0;
            int result = 0;
            foreach (int currentResult in factorialCalculator)
            {
                factorialCalculator.calculateNext = ++counter < numberToCalculate;
                result = currentResult;
            }
            Console.WriteLine(result);
        }

        public static void PrintFactorial(uint numberToCalculate)
        {
            int number = 0;
            int result = 1;
            int counter = 0;
            while (counter++ <numberToCalculate)
            {
                result *= ++number;
            }
            Console.WriteLine(result);
        }
    }
}
