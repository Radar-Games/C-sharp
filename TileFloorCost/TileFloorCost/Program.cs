using System;

namespace TileFloorCost
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double cost, w, h, area, overallCost;

            Console.WriteLine("Cost of one tile:");
            cost = double.Parse(Console.ReadLine());

            Console.WriteLine("How many tile fill one width of the room?");
            w = double.Parse(Console.ReadLine());

            Console.WriteLine("How many tile fill one length of the room?");
            h = double.Parse(Console.ReadLine());

            area = w * h;

            overallCost = area * cost;

            Console.WriteLine("The total cost of the floor is ${0}", overallCost);
        }
    }
}
