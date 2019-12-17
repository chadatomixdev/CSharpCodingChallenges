using System;

namespace HackerRankWarmupChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSocks = 9;
            int[] socks = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = SockMerchant.sockMerchant(numberOfSocks, socks);

            Console.WriteLine($"Matching pairs of socks { result }");
        }
    }
}
