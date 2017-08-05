using System;
namespace QuadraticAttempt2
{
    public class Commands
    {
		public double FindA(double y1_1, double y1_2, double y1_3, double y1_4)
		{
			// /// Variables

			// // First Set
			double y2_1, y2_2, y2_3;

			// // Second Set
			double y3_1, y3_2;

			// // a
			double a;


			// /// Finding 'a'

			// // Finding First Difference Pattern

			// / First Variable
			y2_1 = y1_2 - y1_1;

			// / Second Variable
			y2_2 = y1_3 - y1_2;

			// / Third Variable
			y2_3 = y1_4 - y1_3;

			// // Finding Second Difference Pattern

			// / First Variable
			y3_1 = y2_2 - y2_1;

			// / Second Variable
			y3_2 = y2_3 - y2_2;


			// /// Checking That Values Given Have Quadratic Relationship

			// // Check
			if (y3_1 != y3_2)
			{
				Console.WriteLine("The variables you added are not quadratic");
			}


			// /// Calculating Variable 'a'

			// // Calculation
			a = y3_1 / 2;


			// /// Returning Variable 'a'

			// // Returning
			return a;
		}

		public double FindFirstFirstDifference(double y1_1, double y1_2)
		{
			// /// Variables

			// // First Set
			double y2_1;


			// /// Calculating the First First Difference

			// // Calculation
			y2_1 = y1_2 - y1_1;


			// /// Returning the First First Difference

			// // Return
			return y2_1;
		}

		public double FindSecondDifference(double y1_1, double y1_2, double y1_3)
		{
			// /// Variables

			// // First Diff
			double y2_1, y2_2;

			// // Second Diff
			double y3_1;


			// /// Calculating Second Difference Pattern

			// // Finding First Difference Pattern
			y2_1 = y1_2 - y1_1;
			y2_2 = y1_3 - y1_2;

			// // Finding Second Difference Pattern
			y3_1 = y2_2 - y2_1;


			// /// Returning The Second Difference Pattern

			// // Return
			return y3_1;
		}

        public double FindC (double fDifference, double sDifference, int x1, double y1_1)
        {
            // ///Variables

            // // Numbers
            double num = y1_1, fDiff = fDifference;


            // /// Calculations

            // // Finding the y Intercept
            for (int i = x1; i != 0; i--)
            {
                fDiff -= sDifference;
                num -= fDiff;
            }

            // /// Returning y Intercept

            // // Return
            return num;
        }

        public double FindB (double a, double c, double x1, double y1_1, double x2, double y1_2)
        {
            // /// Variables

            // // Predicted
            double current;

            // // Placeholder
            double i, b;
            if (x1 != 0)
            {
                current = a * x1 * x1 + c;

                i = y1_2 - current;

                b = i / x1;
            }
            else
            {
				current = a * x2 * x2 + c;

                i = y1_2- current;

				b = i / x2;
            }

			return b;
        }

        public void ThoseFuckingNotifications (double a, double b)
        {
            // SMH
        }
    }
}