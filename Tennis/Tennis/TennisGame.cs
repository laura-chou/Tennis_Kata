using System;

namespace Tennis
{
    class TennisGame
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

        public void GivePlayer1Score()
        {
            _player1Score++;
        }
    }
}