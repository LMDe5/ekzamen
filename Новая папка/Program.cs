using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzamen4ik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentExp = 0;
            int currentLevel = 1;
            int expToNextLevel = 0;
            ExperienceSystem experienceSystem = new ExperienceSystem(currentExp, currentLevel, expToNextLevel);
            experienceSystem.AddExperience(600);
            Console.WriteLine( experienceSystem.GetProgress());
            Console.WriteLine("--- --- ---");

            Achievement achievement1 = new Achievement(1, "первыве шаги", "нажмите W", false);
            Achievement achievement2 = new Achievement(1, "вторые шаги", "нажмите A, S, D", false);
            AchievementSystem system = new AchievementSystem();
            system.AddAchievement(achievement1);
            system.AddAchievement(achievement2);
            system.UnlockAchievement(1);
            Console.WriteLine(system.GetProgress());
            Console.WriteLine("--- --- ---");

            Leaderboard leaderboard = new Leaderboard();
            leaderboard.AddScore("Иван", 1500);
            leaderboard.AddScore("Мария", 2000);
            leaderboard.AddScore("Петр", 1200);

            var top3 = leaderboard.GetTopPlayers(3);
            Console.WriteLine(leaderboard.GetPlayerRank("Мария")); 
            Console.WriteLine(leaderboard.GetAverageScore()); 

        }
    }
}
