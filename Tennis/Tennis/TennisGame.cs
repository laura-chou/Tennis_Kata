using System;
using System.Collections.Generic;

namespace Tennis
{
    class TennisGame
    {
        private int _player1Score;
        private Dictionary<int, string> _scoreLookLike = new Dictionary<int, string>
        {
            { 0, "Love"},
            { 1, "Fifteen"},
            { 2, "Thirty"},
            { 3, "Forty"}
        };
        public string GameResult()
        {
            if (_player1Score > 0)
            {
                return _scoreLookLike[_player1Score] + " Love";
            }
            return _scoreLookLike[_player1Score] + " All";
        }

        public void GivePlayer1Score()
        {
            _player1Score++;
        }
    }
}