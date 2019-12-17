using System;
using System.Linq;

namespace HackerRankWarmupChallenges
{
    public static class SockMerchant
    {
        // Complete the sockMerchant function below.
        public static int sockMerchant(int n, int[] ar)
        {
            var pairs = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i+1; j < n; j++)
            //    {
            //        if (ar[i] == ar[j])
            //            pairs++;
            //    }
            //}

            var combinations = ar.SelectMany((element, index) => ar.Skip(index + 1), (sock1, sock2) => Tuple.Create(sock1, sock2));

            foreach (var combination in combinations)
            {
                if (combination.Item1 == combination.Item2)
                    pairs++;
            }

            return pairs;
        }
    }
}