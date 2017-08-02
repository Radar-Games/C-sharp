using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequenceToTheNthNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            TheThing(Convert.ToInt32(Console.ReadLine()));
        }

        static void TheThing(int z)
        {
            Console.WriteLine("\n");

            int number = z;

            int a = 0;
            int b = 1;
            int c = a + b;

            if (number >= 1) Console.WriteLine(a);
            if (number >= 2) Console.WriteLine(b);
            if (number >= 3) Console.WriteLine(c);

            for (int i = 0; i < number-3; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
