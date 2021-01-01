using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamWorkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Teams> roster = new List<Teams>();
            for (int i = 0; i < n; i++)
            {
                string[] teamsToRegister = Console.ReadLine().Split('-');
                string teamLeader = teamsToRegister[0];
                string teamName = teamsToRegister[1];

                if (roster.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (roster.Any(x => x.TeamLeader == teamLeader))
                {
                    Console.WriteLine($"{teamLeader} cannot create another team!");
                    continue;
                }

                Teams team = new Teams(teamLeader, teamName);
                roster.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {teamLeader}!");
            }

            string[] addingMembers = Console.ReadLine().Split("->");

            while (addingMembers[0] != "end of assignment")
            {
                string teamMember = addingMembers[0];
                string teamName = addingMembers[1];

                if (!roster.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    addingMembers = Console.ReadLine().Split("->");
                    continue;
                }
                if (roster.Any(x => x.TeamMembers.Contains(teamMember)) ||
                    roster.Any(x => x.TeamLeader == teamMember && x.TeamName == teamName))
                {
                    Console.WriteLine($"Member {teamMember} cannot join team {teamName}!");
                    addingMembers = Console.ReadLine().Split("->");
                    continue;
                }

                int index = roster.FindIndex(x => x.TeamName == teamName);
                roster[index].TeamMembers.Add(teamMember);

                addingMembers = Console.ReadLine().Split("->");
            }

            var disbanded = roster
                .FindAll(x => x.TeamMembers.Count == 0)
                .OrderBy(x => x.TeamName).ToList();

            var validTeams = roster.FindAll(x => x.TeamMembers.Count > 0)
                .OrderBy(x => x.TeamName).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (Teams item in validTeams.OrderByDescending(x => x.TeamMembers.Count))
            {
                sb.AppendLine($"{item.TeamName}");
                sb.AppendLine($"- {item.TeamLeader}");

                foreach (var member in item.TeamMembers.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }

            sb.AppendLine("Teams to disband:");

            foreach (Teams item in disbanded)
            {
                sb.AppendLine(item.TeamName);
            }
            Console.WriteLine(sb.ToString());
        }

        public class Teams
        {
            public string TeamName { get; set; }
            public string TeamLeader { get; set; }
            public List<string> TeamMembers;

            public Teams(string teamLeader, string teamName)
            {
                TeamName = teamName;
                TeamLeader = teamLeader;
                TeamMembers = new List<string>();
            }
        }
    }
}
