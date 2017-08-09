using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumbers
{
	class MainClass
	{
		static void Main (string[] args)
		{
			bool isPrime = true;

            Console.WriteLine("Prime Numbers: ");

            for (int j = 2; j <= 100; j++)
            {
                for (int i = 2; i <= 100; i++)
                {
                    if (j != i && j % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(j);
                    Console.ReadKey();
				}
				isPrime = true;
			}

			Console.ReadKey();
        }
    }
}