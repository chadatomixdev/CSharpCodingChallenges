using System;
namespace Arithmetic
{
    public class Area
    {
            // Write a function that determines the area of a circle given the radius
            // Formula - Area of a circle: A=πr2

            public static double calculateAreaOfCircle(double radius)
            {
                double pi = Math.PI;
                double area = pi * (radius * radius);

                return area;
            }
    }
}