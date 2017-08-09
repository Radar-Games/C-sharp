using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace PhysicsCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();

                CompareMethods(command, typeof(Methods));
                Console.WriteLine("\n");
            }
        }

        static void CompareMethods(string command, Type type)
        {
            foreach (var method in type.GetMethods())
            {
                if (command == method.Name)
                {
                    method.Invoke(method, null);
                }
            }

            if (command == "help")
            {
                help();
            }
        }

        static void help()
        {
            Type type = typeof(Methods);

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
