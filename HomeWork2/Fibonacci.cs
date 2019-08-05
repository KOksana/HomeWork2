using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Fibonacci
    {
        private class FibonacciGenerator : IEnumerable
        {
            public bool generate = false;
            public IEnumerator GetEnumerator()
            {
                int previous = 0;
                int current = 1;
                int temp;
                generate = true;

                while (generate)
                {
                    temp = current;
                    current += previous;
                    previous = temp;
                    yield return current;
                }
            }
        }

        public static void PrintFibonacciUntilIndexYield(uint index)
        {
            FibonacciGenerator fibonacciGenerator = new FibonacciGenerator();
            int counter = 0;
            foreach (int number in fibonacciGenerator)
            {
                Console.Write(number +" ");
                fibonacciGenerator.generate = ++counter < index;
            }
            Console.WriteLine();
        }

        public static void PrintFibonacciUntilIndex(uint index)
        {
            int previous = 0;
            int current = 1;
            int temp;
            int counter = 0;
            while (counter++ < index)
            {
                temp = current;
                current += previous;
                previous = temp;
                Console.Write(current + " ");
            }
            Console.WriteLine();
        }
    }
}
