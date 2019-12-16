using System.Linq;

namespace Arrays
{
    public static class ArrayManipulation
    {
        //Write a method to add all the elements in an array
        //as of .Net 4.5
        public static int SumAllElemntsInAnArray(int[] numbers)
        {
            return numbers.Sum();
        }

        //Write a method to add all the elements in an array
        public static int SumAllElemntsInAnArrayWithLoop(int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}