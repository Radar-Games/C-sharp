using System;

namespace QuadraticAttempt2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // /// Creating References

            // // Reference to MainClass to Invoke Methods
            Commands com = new Commands();


            // /// Intro

            // // Telling User Requirements
            Console.WriteLine("All 4 x values must be in consecutive order, whole numbers and positive");


            // /// Creating Variables

            // // Base Values
            double y1_1, y1_2, y1_3, y1_4;
            int x1, x2, x3, x4;

			// // Final Values
			double a, b, c;

            // // Difference Values
            double sDifference, fDifference;

            // // Testing
            /*
            x1 = 0;
            x2 = 1;
            x3 = 2;
            x4 = 4;

            y1_1 = -2;
            y1_2 = -2;
            y1_3 = 0;
            y1_4 = 4;
            */

			// /// Get Variables

            // // Getting Values from User
            Console.WriteLine("X:");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            y1_1 = int.Parse(Console.ReadLine());

			// // Getting Second Set
			Console.WriteLine("X:");
			x2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Y:");
			y1_2 = int.Parse(Console.ReadLine());

			// // Getting Third Set
			Console.WriteLine("X:");
            x3 = int.Parse(Console.ReadLine());
			Console.WriteLine("Y:");
            y1_3 = int.Parse(Console.ReadLine());

			// // Getting Fourth Set
			Console.WriteLine("X:");
            x4 = int.Parse(Console.ReadLine());
			Console.WriteLine("Y:");
            y1_4 = int.Parse(Console.ReadLine());

			// / Fucking Notifications
			com.ThoseFuckingNotifications(x3, x4);


            // /// Finding 'a'

            // // Invoking Method and Assigning Variable 'a'
            a = com.FindA (y1_1, y1_2, y1_3, y1_4);

            // // Displaying Variable 'a'
            //Console.WriteLine (a);


            // /// Getting Difference Values

            // // Invoking Method and Assigning Variable 'a'
            fDifference = com.FindFirstFirstDifference (y1_1, y1_2);

            // // Invoking Method and Assigning Value of the First First Difference Pattern
            sDifference = com.FindSecondDifference (y1_1, y1_2, y1_3);


            // /// Finding 'c'

            // // Invoking Method and Assigning Variable 'c'
            c = com.FindC (fDifference, sDifference, x1, y1_1);

            // / Displaying Variable 'c'
            //Console.WriteLine(c);


            // /// Finding 'b'

            // // Invoking Method and Assigning Variable 'b'
            b = com.FindB(a, c, x1, y1_1, x2, y1_2);

            // / Displaying Variable 'b'
            //Console.WriteLine(b);

            // /// Displaying Quadratic Equation

            // // Displaying
            Console.WriteLine("{0}x^2 + {1}x + {2}", a, b, c);

            // / Wait for User
            Console.ReadKey();
        }
    }
}
