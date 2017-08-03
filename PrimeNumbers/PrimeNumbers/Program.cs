
using System;

namespace PrimeNumbers
{
	class MainClass
	{
		static void Main(string[] args)
		{
            MainClass v = new MainClass();
            v.Calculations(int.Parse(Console.ReadLine()));
		}

        void Calculations(int z)
        {
            int pCount = 0;
            int desired = z;
            int i = 2;

            while (desired > pCount)
            {
                i++;

                bool isPrime = true;

                for (int a = 2; a <= i / 2; a++)
                {
                    if (i % a == 0)
                    {
                        isPrime = false;
                        return;
                    }

                }
                if(isPrime)
                {
                    Console.WriteLine(i);
                    pCount += 1;
                }
            }

            Console.ReadLine();
		}
    }
}