using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ekzamen4ik
{
    internal class Leaderboard
    {
        private List<PlayerScore> playerScores = new List<PlayerScore>();
        private PlayerScore playerScore; 

        public void AddScore(string playerName, int score)
        {
            foreach (PlayerScore playerScore in playerScores)
            {
                if (playerScore.PlayerName == playerName)
                {
                    playerScore.Score = score;
                }
            }
        }

        public string GetTopPlayers(int count)
        {
            if (count <= 0)
            {
                return "Введено неверное значение!";
            }
            playerScores.Sort();
            playerScores.Reverse();
            string leadrboardString = "";
            while (count > 0)
            {
                foreach (PlayerScore playerScore in playerScores)
                {
                    leadrboardString += $"{playerScore.PlayerName} ({playerScore.Score})" + ", ";
                    count--;
                }
            }
            return leadrboardString;
        }

        public int GetPlayerRank(string  playerName)
        {
            playerScores.Sort();
            playerScores.Reverse();
            int cnt = 0;
            foreach (PlayerScore playerScore in playerScores)
            {
                cnt++;
                if (playerScore.PlayerName == playerName)
                {
                    return cnt;
                }
            }
            return -1;
        }

        public float GetAverageScore()
        {
            if (playerScores.Count == 0)
            {
                Console.WriteLine("Нет игроков в таблице лидеров!");
                return -1;
            }
            float average = 0f;
            int playerScoresCnt = 0;
            foreach (PlayerScore playerScore in playerScores)
            {
                playerScoresCnt = playerScoresCnt + playerScore.Score;
            }
            average = (float)playerScoresCnt/playerScores.Count;
            return average;
        }
    }
}
