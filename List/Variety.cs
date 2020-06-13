using System;
using System.Collections.Generic;

namespace algorithm_v2.List
{
    public class Variety
    {
        public List<int> GetPrimes(int start, int end)
        {
            List<int> primeList = new List<int>();

            for (int num = start; num <= end; num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num);

                Console.WriteLine("Number {0}", num);
                Console.WriteLine("Sqrt {0}", numSqrt);

                for (int div = 2; div < numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        break;
                    }
                    if (prime)
                    {
                        Console.WriteLine("Prime => {0}", num);
                        primeList.Add(num);
                    }
                }
            }

            return primeList;
        }

        public void LongSubSequence(List<int> numList)
        {
            int count = 1;
            int start = 0;
            int highestCount = 0;
            int pointerForHighest = 0;
            int numWithHighestCount = 0;
            List<int> sequence = new List<int>();

            for (int i = 0; i < numList.Count; i++)
            {
                if (i + 1 == numList.Count)
                {
                    break;
                }
                if (numList[i] == numList[i + 1])
                {
                    count += 1;
                }
                else
                {
                    if (count > highestCount)
                    {
                        numWithHighestCount = numList[i];
                        highestCount = count;
                        pointerForHighest = start;
                    }
                    count = 1;
                    start = i;
                }

            }
            Console.WriteLine("Highest Count = {0}", highestCount);
            Console.WriteLine("Pointer For Highest = {0}", pointerForHighest);
            Console.WriteLine("Number with Highest count = {0}", numWithHighestCount);
        }
    }
}