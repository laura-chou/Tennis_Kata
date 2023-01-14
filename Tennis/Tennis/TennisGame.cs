using System;
using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Score;
        Dictionary<int, string> _scoreLookLike = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
        };
        public string GameResult()
        {
            if (_player1Score > 0)
            {
                return $"{_scoreLookLike[_player1Score]} Love";
            }
            return $"{_scoreLookLike[_player1Score]} All";
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