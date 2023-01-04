using System;
using System.Collections.Generic;

namespace Tennis
{
    class TennisGame
    {
        private int _player1Score;
        private int _player2Score;
        private string _player1Name;
        private string _player2Name;

        private Dictionary<int, string> _scoreLookLike = new Dictionary<int, string>
        {
            { 0, "Love"},
            { 1, "Fifteen"},
            { 2, "Thirty"},
            { 3, "Forty"}
        };
        

        public TennisGame(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string GameResult()
        {
            if (IsDeuce())
            {
                if (IsPlayer1ScoreZero())
                {
                    return _scoreLookLike[_player1Score] + " All";
                }
                return "Deuce";
            }

            if (IsReadyGamePont())
            {
                var calcScoreResult = Math.Abs(_player1Score - _player2Score);
                var winnerPlayerName = (_player1Score > _player2Score) ? _player1Name : _player2Name;

                Dictionary<int, string> scoreResultLookLike = new Dictionary<int, string>
                {
                    { 1, "Advantage"},
                    { 2, "Win"}
                };

                if (calcScoreResult < 3)
                {
                    return $"{winnerPlayerName} {scoreResultLookLike[calcScoreResult]}";
                }
            }

            return $"{_scoreLookLike[_player1Score]} {_scoreLookLike[_player2Score]}";
        }

        private bool IsReadyGamePont()
        {
            return _player1Score >= 3 || _player2Score >= 3;
        }

        private bool IsPlayer1ScoreZero()
        {
            return _player1Score == 0;
        }

        private bool IsDeuce()
        {
            return _player1Score == _player2Score;
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