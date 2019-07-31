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
            Console.WriteLine("Choose task: 1 - Task1 (fibonacci and factorial); 2 - Task2 (add index range)");

            string inputValue = Console.ReadLine();
            if (int.TryParse(inputValue, out int taskNumber))
            {
                switch (taskNumber)
                {
                    case 1:

                        break;
                    case 2:
                        Task2.Processing();
                        break;
                    default:
                        Console.WriteLine("There are no task with this number");
                        Console.Read();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input number");
                Console.Read();
            }
        }
    }
}
