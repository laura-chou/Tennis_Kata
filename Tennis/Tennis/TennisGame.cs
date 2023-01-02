using System;
using System.Collections.Generic;

namespace Tennis
{
    class TennisGame
    {
        private int _player1Score;
        private int _player2Score;

        private Dictionary<int, string> _scoreLookLike = new Dictionary<int, string>
        {
            { 0, "Love"},
            { 1, "Fifteen"},
            { 2, "Thirty"},
            { 3, "Forty"}
        };

        public string GameResult()
        {
            if (_player1Score == _player2Score)
            {
                if (_player1Score == 0)
                {
                    return _scoreLookLike[_player1Score] + " All";
                }
                return "Deuce";
            }

            if (_player1Score > 1 && Math.Abs(_player1Score - _player2Score) == 1)
            {
                return $"Player A Advantage";
            }
            return $"{_scoreLookLike[_player1Score]} {_scoreLookLike[_player2Score]}";
        }

        public void GivePlayer1Score()
        {
            _player1Score++;
        }

        public void GivePlayer2Score()
        {
            _player2Score++;
        }
    }
}