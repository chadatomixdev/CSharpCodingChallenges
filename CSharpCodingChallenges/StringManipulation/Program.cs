using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var reversedString = StringManipulation.ReverseString("Test");
            Console.WriteLine($"Reversed String: { reversedString } ");

            var stringcase = StringManipulation.ReturnStringCase("A");
            Console.WriteLine($"String case is: { stringcase } ");
        }
    }
}