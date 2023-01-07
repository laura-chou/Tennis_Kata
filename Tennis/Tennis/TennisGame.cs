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