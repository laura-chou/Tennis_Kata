using System;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Score;
        public string ScoreResult()
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

        internal void GivePlayer1Score()
        {
            _player1Score++;
        }
    }
}