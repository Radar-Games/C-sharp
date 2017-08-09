using System;

namespace PhysicsCalculator
{
    public static class LinearMotion
    {
		public static void LinearDisplacement()
		{
			double x1, x2, tDisplacement;

			Console.WriteLine("Initial Position of the Object");
			x1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Final Position of the Object");
			x2 = double.Parse(Console.ReadLine());

			tDisplacement = x2 - x1;

			Console.WriteLine("The Linear Displacment is {0} m", tDisplacement);
		}

		public static void AverageVelocityUsingDisplacement()
		{
			double x1, x2, t1, t2, xDiff, tDiff, avVel;

			Console.WriteLine("Inital Displacement of the Object");
			x1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Final Displacement of the Object");
			x2 = double.Parse(Console.ReadLine());

			Console.WriteLine("Initial Time");
			t1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Final Time");
			t2 = double.Parse(Console.ReadLine());

			xDiff = x2 - x1;
			tDiff = t2 - t1;

			avVel = xDiff / tDiff;

			Console.WriteLine("The Average Velocity is {0} m/s", avVel);
		}

		public static void AverageVelocityUsingVelocity()
		{
			double u, v, t, velDiff, avVel;

			Console.WriteLine("Initial Velocity of Object");
			u = double.Parse(Console.ReadLine());

			Console.WriteLine("Final Velocity of Object");
			v = double.Parse(Console.ReadLine());

			Console.WriteLine("Time Taken");
			t = double.Parse(Console.ReadLine());

			velDiff = v - u;

			avVel = velDiff / t;

			Console.WriteLine("The Average Velocity is {0} m/s", avVel);
		}

		public static void InstantaneousVelocity()
		{
			double dx, dt, InstantaneousVelocity;

			Console.WriteLine("Displacement of Object");
			dx = double.Parse(Console.ReadLine());

			Console.WriteLine("Time Passed");
			dt = double.Parse(Console.ReadLine());

			InstantaneousVelocity = dx / dt;

			Console.WriteLine("Instantaneous Velocity of Object at Specified point is {0} m/s", InstantaneousVelocity);
		}
    }
}
