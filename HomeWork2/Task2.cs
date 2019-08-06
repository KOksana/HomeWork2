using System;
using System.Collections.Generic;

namespace HomeWork2
{
    public class Task2
    {
        public static void Processing()
        {
            IList<int> array = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                array.Add(i);
            }

            Console.WriteLine("Init array:");
            foreach(int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            ElementList accessor = new ElementList(array);

            string firstIndexValue;
            string lastIndexValue;
            int firstIndex;
            int lastIndex;

            Console.WriteLine("Enter range of elements to add them into new array. Indexes start from 1. Both indexes should be > 0 or both < 0");

            while (true)
            {
                Console.WriteLine("---------------------------------------");
                Console.Write("First index: ");
                firstIndexValue = Console.ReadLine();
                if (firstIndexValue.Equals("q", StringComparison.OrdinalIgnoreCase))
                    break;

                if (!int.TryParse(firstIndexValue, out firstIndex))
                {
                    Console.WriteLine("Invalid input value");
                    continue;
                }

                Console.Write("Last index: ");

                lastIndexValue = Console.ReadLine();

                if (lastIndexValue.Equals("q", StringComparison.OrdinalIgnoreCase))
                    break;

                if (!int.TryParse(lastIndexValue, out lastIndex))
                {
                    Console.WriteLine("Invalid input value");
                    continue;
                }

                accessor.AddIndexRange(firstIndex, lastIndex);
                Console.WriteLine("New array:");
                foreach (int element in accessor)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
