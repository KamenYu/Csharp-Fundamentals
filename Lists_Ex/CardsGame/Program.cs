using System;
using System.Linq;
using System.Collections.Generic;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deckOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> deckTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < deckOne.Count; i++)
            {
                if (deckOne[i] > deckTwo[i])
                {
                    deckOne.Add(deckOne[i]);
                    deckOne.Add(deckTwo[i]);
                }
                else if (deckTwo[i] > deckOne[i])
                {
                    deckTwo.Add(deckTwo[i]);
                    deckTwo.Add(deckOne[i]);
                }
                deckOne.RemoveAt(i);
                deckTwo.RemoveAt(i);

                List<int> winningDeck = new List<int>();

                if (deckOne.Count == 0)
                {
                    winningDeck = deckTwo;
                    Console.WriteLine($"Second player wins! Sum: {deckTwo.Sum()}");
                    break;
                }
                else if (deckTwo.Count == 0)
                {
                    winningDeck = deckOne;
                    Console.WriteLine($"First player wins! Sum: {deckOne.Sum()}");
                    break;
                }
                i--;
            }
        }
    }
}
