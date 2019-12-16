using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            var circleRadius = 75.22;
            var area = Area.calculateAreaOfCircle(circleRadius);

            Console.WriteLine($"The area of the circle wih radius: { circleRadius } is { area }");
        }
    }
}
