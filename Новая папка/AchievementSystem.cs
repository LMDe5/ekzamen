using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzamen4ik
{
    internal class AchievementSystem
    {
        private List<Achievement> achievements = new List<Achievement> ();

        private Achievement achievement;
        public AchievementSystem()
        {
        }
        public void AddAchievement(Achievement achievement)
        {
            achievements.Add (achievement);
        }
        public bool UnlockAchievement(int achievementId)
        {
            foreach (Achievement achievement in achievements)
            {
                if (achievement.Id == achievementId)
                {
                    achievement.IsUnlocked = true;
                    return true;
                }
            }
            return false;
        }

        public string GetAchievement(int achievementId)
        {
            foreach (Achievement achievement in achievements)
            {
                if (achievement.Id == achievementId)
                {
                    return achievement.Name;
                }
            }
            return null;
        }

        public int GetUnlockedCount()
        {
            int cnt = 0;
            foreach (Achievement achievement in achievements)
            {
                if (achievement.IsUnlocked == true)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        public void GetAllUnlocked()
        {
            foreach(Achievement achievement in achievements)
            {
                if (achievement.IsUnlocked == true)
                {
                    Console.WriteLine(achievement.Name);
                }
            }
        }

        public string GetProgress()
        {
            return $"Достижения: [{GetUnlockedCount()}]/[{achievements.Count}]";
        }
    }
}
