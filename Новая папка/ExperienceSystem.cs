using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace ekzamen4ik
{
    internal class ExperienceSystem
    {
        public int currentExp { get; set; }
        public int currentLevel { get; set; }
        public int expToNextLevel { get; set; }

        public ExperienceSystem(int currentExp, int currentLevel, int expToNextLevel)
        {
            this.currentExp = currentExp;
            this.currentLevel = currentLevel;
            this.expToNextLevel = expToNextLevel;
        }

        public void AddExperience(int exp)
        {
            if (exp < 0)
            {
                Console.WriteLine("Нельзя прибавить к уровню отрицательное значение!");
                return;
            }
            currentExp += exp;
            expToNextLevel = 100 * currentLevel * currentLevel;
            while (currentExp >= expToNextLevel)
            {
                currentLevel++;
                currentExp = currentExp - expToNextLevel;
                expToNextLevel = 100 * currentLevel * currentLevel;
            }
        }

        public string GetProgress()
        {
            return $"Уровень: [{currentLevel}]: [{currentExp}]/[{expToNextLevel}] XP";
        }
    }
}
