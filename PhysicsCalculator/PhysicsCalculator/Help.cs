using System;
namespace PhysicsCalculator
{
    public class Help
    {
        public static void LinearMotion()
        {
            Type type = typeof(LinearMotion);

            foreach (var method in type.GetMethods())
            {
                if (method.Name != "Equals" && method.Name != "GetHashCode" && method.Name != "GetType" && method.Name != "ToString")
                {
                    Console.WriteLine(method.Name);
                }
            }
        }
    }
}
