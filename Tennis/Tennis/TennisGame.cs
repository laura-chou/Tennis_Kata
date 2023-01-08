using System;
using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Score;
        private int _player2Score;
        private readonly string _player1Name;
        private readonly string _player2Name;
        private Dictionary<int, string> _scoreLookLike = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        public TennisGame(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string ScoreResult()
        {
            if (_player1Score != _player2Score )
            {
                if(_player1Score >= 3 && Math.Abs(_player1Score - _player2Score) == 1)
                {
                    var advPlayerName = _player1Score > _player2Score ? _player1Name : _player2Name;
                    return $"{advPlayerName} Advantage";
                }
                return $"{_scoreLookLike[_player1Score]} {_scoreLookLike[_player2Score]}"; 
            }
            if (_player1Score >= 3)
            {
                return "Deuce";
            }
            return $"{_scoreLookLike[_player1Score]} All";
        }

        internal void GivePlayer1Score()
        {
            _player1Score++;
        }

        internal void GivePlayer2Score()
        {
            _player2Score++;
        }
    }
}