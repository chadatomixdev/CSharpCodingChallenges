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

        //You are given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates.
        //You are allowed to swap any two elements. You need to find the minimum number of swaps required to sort the array in ascending order.
        public static int minimumSwaps(int[] arr)
        {

            var SortedArray = arr.OrderBy(i => i).ToArray();
            var unsortedArray = arr;
            var minSwaps = 0;

            var temp = 0;

            //Looping through the sorted array
            for (int i = 0; i < SortedArray.Length; i++)
            {
                //Comparing the unsorted array to the sorted array
                if (SortedArray[i] != unsortedArray[i])
                {
                    temp = unsortedArray[i];
                    unsortedArray[i] = SortedArray[i];

                    for (int j = i +1; j < SortedArray.Length; j++)
                    {
                        if (unsortedArray[j] == SortedArray[i])
                        {
                            unsortedArray[j] = temp;
                            minSwaps++;
                            break;
                        }
                    }
                }

            }

            return minSwaps;
        }

    }
}