using System.Threading.Channels;

namespace _1._TeamworkProjects
{
    // 1. create a class 
    class Team
    {
        // 2. create a constructor
        public Team(string name, string creatorName)
        {
            Name = name;
            Creator = creatorName;
            Members = new List<string>();
        }
        public string Name { get; set; }// properties (1) 
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        //3. create an override
        public override string ToString()
        {
            return $"{Name}\n" +
                   $"- {Creator}\n" +
                   $"{GetMembersString()}";//4. create a method
        }

        public string GetMembersString()
        {
            Members = Members.OrderBy(name=>name).ToList();
            string result = string.Empty;
            for (int i = 0; i < Members.Count-1; i++)
            {
                result += $"-- {Members[i]}\n";
            } 
            result += $"-- {Members[Members.Count-1]}";

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());//5. read an input
            List<Team> teams = new List<Team>();
            for (int i = 0; i < count; i++)
            {
                string[] teamCommands = Console.ReadLine().Split("-");

                Team team = new Team(teamCommands[1], teamCommands[0]);
                Team sameTeamFound = teams.Find(t => t.Name == team.Name);
                if (sameTeamFound != null)
                {
                    Console.WriteLine($"Team {sameTeamFound.Name} was already created!");
                    continue;
                }

                Team sameCreatorFound = teams.Find(t => t.Creator == team.Creator);
                if (sameCreatorFound != null)
                {
                    Console.WriteLine($"{sameCreatorFound.Creator} cannot create another team!");
                    continue;
                }

                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");
                string joinerName = arguments[0];
                string teamName = arguments[1];

                bool teamWithSameName = teams.Any(t=>t.Name == teamName);
                if (teamWithSameName == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(team=>team.Creator==joinerName) || teams.Any(team=>team.Members.Contains(joinerName)))
                {
                    Console.WriteLine($"Member {joinerName} cannot join team {teamName}!");
                    continue;
                }

                teams.First(t=>t.Name==teamName).Members.Add(joinerName);

                //Team t = teams.First(t => t.Name == teamName);
                //if (t != null)
                //{
                //    t.Members.Add(joinerName);
                //}

            }
            List<Team> leftTeams = teams.Where(t=>t.Members.Count>0).ToList();
            List<Team> orderedTeams = leftTeams.OrderByDescending(t=>t.Members.Count).ThenBy(t=>t.Name).ToList();

            orderedTeams.ForEach(team=>Console.WriteLine(team));
            List<Team> disbandTeams = teams.Where(t => t.Members.Count <= 0).ToList();

            Console.WriteLine("Teams to disband:");
            disbandTeams = disbandTeams.OrderBy(t => t.Name).ToList();
            disbandTeams.ForEach(team => Console.WriteLine(team));

        }
    }
}