using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string seq = Console.ReadLine();

            int[] currentBestArr = new int [n];
            int bestLength = 1;
            int bestStart = 0;
            int bestSum = 0;
            int bestSeqIndex = 0;
            int counter = 0;
            
            while (seq != "Clone them!")
            {
                int[] arr = seq
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                counter++;

                int currentLength = 1;
                int currentBestLength = 1;
                int currentSum = 0;
                int currentStart = 0;
                
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == arr [i+1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                    }
                    
                    if (currentLength > currentBestLength)
                    {
                        currentBestLength = currentLength;
                        currentStart = i;                      
                    }
                    else
                    {
                        currentLength = 1;
                    }
                    currentSum += arr[i];
                }

                currentSum += arr[n - 1];

                if (currentBestLength > bestLength)
                {
                    bestLength = currentBestLength;
                    bestStart = currentStart;
                    bestSum = currentSum;
                    bestSeqIndex = counter;
                    currentBestArr = arr.ToArray();
                }
                else if (currentBestLength == bestLength)
                {
                    if (currentStart < bestStart)
                    {
                        bestLength = currentBestLength;
                        bestStart = currentStart;
                        bestSum = currentSum;
                        bestSeqIndex = counter;
                        currentBestArr = arr.ToArray();
                    }
                    else if (currentStart == bestStart)
                    {
                        if (currentSum > bestSum)
                        {
                            bestLength = currentBestLength;
                            bestStart = currentStart;
                            bestSum = currentSum;
                            bestSeqIndex = counter;
                            currentBestArr = arr.ToArray();
                        }
                    }
                }
                seq = Console.ReadLine();
            }
            
            Console.WriteLine($"Best DNA sample {bestSeqIndex} with sum: {bestSum}.");
            Console.WriteLine(String.Join(' ', currentBestArr));
        }
    }
}
