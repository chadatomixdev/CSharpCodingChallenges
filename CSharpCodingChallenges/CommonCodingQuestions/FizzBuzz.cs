using System;
using System.Linq;

namespace CommonCodingQuestions
{
    public static class FizzBuzz
    {
        /**
        Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz"
        instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
        */
        public static void CalculateFizzBuzz()
        {
            for (int i = 0; i <= 100; i++)
            {
                //Use the remainder operator to calculate if the remainder after dividing the number is 0
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Calculate FizzBuzz using Ternery Operator
        /// </summary>
        public static void CalculateFizzBuzzTernary()
        {
            for (int i = 0; i < 100; i++)
            {
                string res = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" :
                    (i % 3 == 0) ? "Fizz" :
                    (i % 5 == 0) ? "Buzz" :
                    i.ToString();

                Console.Write(res);

            }
        }

        /// <summary>
        /// Calculate FizzBuzz using Linq
        /// </summary>
        public static void CalculateFizzBuzzLinq()
        {
            Enumerable.Range(0, 100).ToList().ForEach(i => Console.WriteLine(
                                i % 3 * i % 5 == 0
                                ? (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "")
                                : i.ToString()));
        }
    }
}
