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
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void GivePlayer1Score()
        {
            _player1Score++;
        }
    }
}