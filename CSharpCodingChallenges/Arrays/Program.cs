using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var sum1 = ArrayManipulation.SumAllElemntsInAnArray(numbers);
            Console.WriteLine(sum1.ToString());

            var sum2 = ArrayManipulation.SumAllElemntsInAnArrayWithLoop(numbers);
            Console.WriteLine(sum2.ToString());


            int[] unsortedArray = { 7, 1, 3, 2, 4, 5, 6 };

            var minSwaps = ArrayManipulation.minimumSwaps(unsortedArray);
            Console.WriteLine($"Min Swaps - { minSwaps.ToString() }");
        }
    }
}