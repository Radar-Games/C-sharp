using System;

namespace ChangeReturnProgram
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // /// Intro

            // // Displaying information
            Console.WriteLine("Input values without dollar sign");

            // /// Variables

            // // User Input
            double paid, cost, change;


            // /// Get Variables from User

            // // Get Variables and Display Info

            // / Display Info
            Console.WriteLine("What is the cost of the item");

            // / Get Variable
            cost = double.Parse(Console.ReadLine());

            // / Display Info
            Console.WriteLine("How much did you play");

            // / Get Variable
            paid = double.Parse(Console.ReadLine());


            // /// Calculations

            // // Calculating return amount
            change = paid - cost;


            // /// Displaying Change

            // // Display

            // / Display in dollars
            if (change >= 1)
            {
                Console.WriteLine("$" + change);
            }

            // / Display in cents
            if (change < 1)
            {
                Console.WriteLine(change * 100 + "c");
            }
        }
    }
}
