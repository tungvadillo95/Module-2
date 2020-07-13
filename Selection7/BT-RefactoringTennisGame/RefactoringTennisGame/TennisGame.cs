using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringTennisGame
{
    class TennisGame
    {
        const string READ_SCORE_0 = "Love";
        const string READ_SCORE_1 = "Fifteen";
        const string READ_SCORE_2 = "Thirty";
        const string READ_SCORE_3 = "Forty";
        const int SCORE_0 = 0;
        const int SCORE_1 = 1;
        const int SCORE_2 = 2;
        const int SCORE_3 = 3;
        const int MIN_SCORE_TO_WIN = 4;
        public static string GetScore(string player1_Name, string player2_Name, int score_Player1, int score_Player2)
        {
            string score="";
            if (score_Player1 == score_Player2)
            {
                ReadScore(score_Player1,ref score);
            }
            else if (score_Player1 >= MIN_SCORE_TO_WIN || score_Player2 >= MIN_SCORE_TO_WIN)
            {
                CheckWin(player1_Name, player2_Name, score_Player1, score_Player2, ref score);
            }
            else
            {
                UnqualifiedWin(score_Player1, score_Player2, ref score);
            }
            return score;
        }
        public static void ReadScore(int score_Player, ref string score)
        {
            switch (score_Player)
            {
                case SCORE_0:
                    score += $"{READ_SCORE_0}-All";
                    break;
                case SCORE_1:
                    score += $"{READ_SCORE_1}-All";
                    break;
                case SCORE_2:
                    score += $"{READ_SCORE_2}-All";
                    break;
                case SCORE_3:
                    score += $"{READ_SCORE_3}-All";
                    break;
                default:
                    score = "Deuce";
                    break;
            }
        }
        public static void CheckWin(string player1_Name, string player2_Name, int score_Player1, int score_Player2,ref string score)
        {
            int minusResult = score_Player1 - score_Player2;
            if (minusResult == 1) score = $"Advantage player1: {player1_Name}";
            else if (minusResult == -1) score = $"Advantage player2: {player2_Name}";
            else if (minusResult >= 2) score = $"Win for player1: {player1_Name}";
            else score = $"Win for player2: {player2_Name}";
        }
        public static void UnqualifiedWin(int score_Player1, int score_Player2, ref string score)
        {
            int tempScore = 0;
            for (int i = 1; i < 3; i++)
            {
                if (i == 1) tempScore = score_Player1;
                else { score += "-"; tempScore = score_Player2; }
                switch (tempScore)
                {
                    case SCORE_0:
                        score += READ_SCORE_0;
                        break;
                    case SCORE_1:
                        score += READ_SCORE_1;
                        break;
                    case SCORE_2:
                        score += READ_SCORE_2;
                        break;
                    case SCORE_3:
                        score += READ_SCORE_3;
                        break;
                }
            }
        }
    }
}
