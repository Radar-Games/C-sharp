using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPIToTheNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many decimal places?");

            int number = Convert.ToInt32(Console.ReadLine());
            const double e = Math.E;
            double final;

            if (number <= 15)
            {
                final = Math.Round(e, number);
                Console.WriteLine("e to " + number + " decimal places is " + final + "\n");
                Console.WriteLine("Press any key to end program");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Number is too big \n");
                Console.WriteLine("Press any key to end program");
                Console.ReadKey();
            }
        }
    }
}