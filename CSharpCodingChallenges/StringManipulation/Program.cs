using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var reversedString = StringManipulation.ReverseString("Test");
            Console.WriteLine($"Reversed String: { reversedString } ");
        }
    }
}