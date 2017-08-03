using System;

namespace HeadsOrTails
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.ReadKey();

                Random rand = new Random();

                double a = rand.Next(1, 100);

                if (a <= 50)
                {
                    Console.WriteLine("Heads");
                }

                if (a >= 51)
                {
                    Console.WriteLine("Tails");
                }
            }
        }
    }
}
