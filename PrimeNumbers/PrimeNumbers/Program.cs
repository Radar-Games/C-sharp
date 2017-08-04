
using System;

namespace PrimeNumbers
{
	class MainClass
	{
		static void Main (string[] args)
		{
            while (true)
            {
                MainClass v = new MainClass();
                v.Calculations(int.Parse(Console.ReadLine()));
            }
		}

        void Calculations (int z)
        {
            int a = z;
            bool isPrime = true;

            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == true)
            {
                Console.WriteLine("Number is aprime");
            }

            if (isPrime == false)
            {
                Console.WriteLine("Number is not prime");
            }
		}
    }
}