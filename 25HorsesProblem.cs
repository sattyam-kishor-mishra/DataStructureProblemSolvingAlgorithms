using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class Horse
    {
        public string HorseName { get; set; } = string.Empty;
        public int Speed { get; set; }
    }

    public static class _25HorsesProblem
    {
        public static void FindWinner()
        {
            var horses = new List<Horse>();
            var rand = new Random();

            for (int i = 1; i <= 25; i++)
            {
                horses.Add(new Horse { HorseName = $"H{i}" , Speed = rand.Next(1, 100)});
            }

            var horseGroup = horses
                .Select((h, i) => new { Horse = h, Index = i})
                .GroupBy(h => h.Index/5)
                .Select(g=> g.Select(x=> x.Horse).ToList())
                .ToList();

            var groupResultFromFirstFiveRaces = horseGroup.Select(RunRace).ToList();

            var winnerFromFirstFiveRaces = groupResultFromFirstFiveRaces.Select(h=> h[0]).ToList();

            var groupResultsFromSixthRace = RunRace(winnerFromFirstFiveRaces);


            var g1R7 = groupResultFromFirstFiveRaces[horseGroup.IndexOf(horseGroup.Find(g => g.Contains(groupResultsFromSixthRace[0]))!)];
            var g2R7 = groupResultFromFirstFiveRaces[horseGroup.IndexOf(horseGroup.Find(g => g.Contains(groupResultsFromSixthRace[1]))!)];
            var g3R7 = groupResultFromFirstFiveRaces[horseGroup.IndexOf(horseGroup.Find(g => g.Contains(groupResultsFromSixthRace[2]))!)];



            var horesForRaceSeven = new List<Horse>
            {
                g1R7[1], g1R7[2],
                g2R7[0], g2R7[1],
                g3R7[0]
            };

            var finalRace = RunRace(horesForRaceSeven);

            Console.WriteLine("Fastest Horse: " + groupResultsFromSixthRace[0].HorseName);
            Console.WriteLine("2nd Fastest: " + finalRace[0].HorseName);
            Console.WriteLine("3rd Fastest: " + finalRace[1].HorseName);


        }

        private static List<Horse> RunRace (List<Horse> horses)
        {
            return horses.OrderByDescending(h => h.Speed).ToList();
        }
 
    }

}
