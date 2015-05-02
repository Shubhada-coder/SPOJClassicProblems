using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ_Classic_Prime1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<int> lowerLimit = new List<int>();
            List<int> upperLimit = new List<int>();
            for (int input = 0; input < t; input++)
            {
                var inputString = Console.ReadLine().Split(' ');
                lowerLimit.Add(Convert.ToInt32(inputString[0]));
                upperLimit.Add(Convert.ToInt32(inputString[1]));

            }
            for (int iteration = 0; iteration < t; iteration++)
            {

                printPrimes(lowerLimit[iteration], upperLimit[iteration]);

            }

        }

        public static void printPrimes(int lowerLimit, int upperLimit)
        {
            bool isPrime = true;
            for (int number = lowerLimit; number <= upperLimit; number++)
            {
                if (number <= 1)
                {
                    isPrime = false;
                    continue;
                }
                else if (number <= 3)
                {
                    isPrime = true;
                }

                else if (number % 2 == 0 || number % 3 == 0)
                {
                    isPrime = false;
                    continue;
                }
                else
                {
                    int i = 5;
                    isPrime = true;
                    while (i * i <= number)
                    {
                        if (number % i == 0 || number % (i + 2) == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        i = i + 6;

                    }
                    
                }

                if (isPrime)
                {
                    Console.WriteLine(number);

                }
            }
            Console.WriteLine();
        }

    }
}
