using System;

namespace RoverDirections
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution(new Coordinates(0, 1, Direction.East), "MML");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Console.WriteLine(coordinates.X);
            Console.WriteLine(coordinates.Y);
            Console.WriteLine(coordinates.direction.ToString());
            Console.ReadKey(true);
        }
    }
}
