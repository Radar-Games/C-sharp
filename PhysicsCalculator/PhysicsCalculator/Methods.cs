using System;

namespace PhysicsCalculator
{
    public class Methods
    {
		// Linear Motion

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

        public static void AccelarationUsingChange()
        {
            double dv, dt, accelaration;

            Console.WriteLine("Change in Velocity");
            dv = double.Parse(Console.ReadLine());

            Console.WriteLine("Change in Time");
            dt = double.Parse(Console.ReadLine());

            accelaration = dv / dt;

            Console.WriteLine("The Accelaration of the Object is {0} m/s/s", accelaration);
        }

        public static void AccelarationUsingBase()
        {
            double v1, v2, t1, t2, tDiff, vDiff, accelaration;

            Console.WriteLine("Initial Velocity");
            v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Final Velocity");
            v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Initial Time");
            t1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Final Time");
            t2 = double.Parse(Console.ReadLine());

            vDiff = v2 - v1;
            tDiff = t2 - t1;

            accelaration = vDiff / tDiff;

            Console.WriteLine("The Acclaration of the Object is {0} m/s/s", accelaration);
        }

        // Force

        public static void NewtonsFirstLawDef()
        {
            Console.WriteLine("The Law of Inertia");
            Console.WriteLine("An object at rest will remain at rest unless acted upon by an unbalanced force. An object in motion continues in motion with the same direction and speed unless acted upon by an unbalanced force");
        }

        public static void NewtonsSecondLawDef()
        {
            Console.WriteLine("Net of Forces");
            Console.WriteLine("The heavier an object is the more force needs to be applied to the object for it to move");
            Console.WriteLine("The formula the illustrates this Relationship is Fnet = MA");
            Console.WriteLine("Example:");
            Console.WriteLine("Kicking a wall does not move the wall because of its weight but kicking a ball moves the ball");
        }

        public static void NewtonsThirdLawDef()
        {
            Console.WriteLine("Equal and Opposite Forces");
            Console.WriteLine("If an object A exerts a force on object B, then object B must exert a force of equal magnitude and opposite direction back on object A.");
            Console.WriteLine("Example:");
            Console.WriteLine("The Earth pulls you done but also pushs you away with the same amount of force");
        }

        public static void NewtonsSecondLaw()
        {
            double Fnet, m, a;

            Console.WriteLine("Mass of object");
            m = double.Parse(Console.ReadLine());

            Console.WriteLine("Accelaration of object");
            a = double.Parse(Console.ReadLine());

            Fnet = m * a;

            Console.WriteLine("The Net force being acted upon by the object is {0} Newtons", Fnet);
        }
    }
}
