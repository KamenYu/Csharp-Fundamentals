using System;
using System.Linq;
using System.Collections.Generic;

namespace MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            // "{player} -> {position} -> {skill}"
            // "{player} vs {player}"

            string input = string.Empty;
            Dictionary<string, Dictionary<string, int>> playersLog = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] tokens = input.Split();

                if (tokens[1] == "->")
                {
                    string player = tokens[0];
                    string position = tokens[2];
                    int skill = int.Parse(tokens[4]);

                    if (playersLog.ContainsKey(player))
                    {
                        if (playersLog[player].ContainsKey(position))
                        {
                            if (playersLog[player][position] < skill)
                            {
                                playersLog[player][position] = skill;
                            }
                        }
                        else
                        {
                            playersLog[player].Add(position, skill);
                        }
                    }
                    else
                    {
                        playersLog.Add(player, new Dictionary<string, int>());
                        playersLog[player].Add(position, skill);
                    }
                }
                else
                {
                    string playerOne = tokens[0];
                    string playerTwo = tokens[2];

                    if (playersLog.ContainsKey(playerOne) && playersLog.ContainsKey(playerTwo))
                    {
                        List<string> positionsOne = playersLog[playerOne].Keys.ToList();
                        List<string> positionsTwo = playersLog[playerTwo].Keys.ToList();

                        int totalPointsOne = playersLog[playerOne].Values.Sum();
                        int totalPointsTwo = playersLog[playerTwo].Values.Sum();

                        if (PositionChecker(positionsOne, positionsTwo))
                        {
                            if (totalPointsOne > totalPointsTwo)
                            {
                                playersLog.Remove(playerTwo);
                            }
                            else
                            {
                                playersLog.Remove(playerOne);
                            }
                        }                        
                    }
                }
            }
            int sum = 0;
            Dictionary<string, int> totalSkills = new Dictionary<string, int>();

            foreach (var player in playersLog)
            {
                foreach (var val in player.Value)
                {
                    sum += val.Value;
                }
                totalSkills.Add(player.Key, sum);
                sum = 0;
            }

            foreach (var player in totalSkills.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");

                foreach (var item in playersLog[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }

        private static bool PositionChecker(List<string> positionsOne, List<string> positionsTwo)
        {
            foreach (var item in positionsOne)
            {
                foreach (var it in positionsTwo)
                {
                    if (it == item)
                    {
                        return true;
                    }
                }
            }
            return false;            
        }
    }
}
