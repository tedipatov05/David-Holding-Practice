using System;

namespace _08._Ranking
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string command;

            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] input = command.Split(':');

                string contest = input[0];
                string password = input[1];

                contests[contest] = password;
            }

            var results = new Dictionary<string, Dictionary<string, int>>();

            string submissionCommand;

            while ((submissionCommand = Console.ReadLine()) != "end of submissions")
            {
                string[] submissionInput = submissionCommand.Split("=>");

                string contest = submissionInput[0];
                string password = submissionInput[1];
                string username = submissionInput[2];
                int points = int.Parse(submissionInput[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!results.ContainsKey(username))
                    {
                        results[username] = new Dictionary<string, int>();
                    }

                    if (results.ContainsKey(username) && !results[username].ContainsKey(contest))
                    {
                        results[username][contest] = 0;
                    }

                    if (results[username][contest] < points)
                    {
                        results[username][contest] = points;
                    }
                }
            }

            string winner = results.OrderBy(x => x.Value.Values.Sum()).Last().Key;
            int bestPoints = results.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

            Console.WriteLine($"Best candidate is {winner} with total {bestPoints} points.");

            Console.WriteLine("Ranking:");

            foreach (var item in results.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}