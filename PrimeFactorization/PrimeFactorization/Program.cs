using System;

namespace PrimeFactorization
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your integer: ");
                                
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine("{0} is a factor of {1}", i, a);
                }     
            }

            Console.ReadLine();
        }
    }
}
