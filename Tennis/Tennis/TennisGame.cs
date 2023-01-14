using System;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Score;

        public string GameResult()
        {
            if (_player1Score > 0)
            {
                if (_player1Score == 2)
                {
                    return "Thirty Love";
                }
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void GivePlayer1ScoreTimes(int times)
        {
            for (int i = 0;i < times;i++)
            {
                _player1Score++;
            }
        }
    }
}