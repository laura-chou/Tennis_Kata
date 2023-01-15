using System;
using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame
    {
        private readonly string _player1Name;
        private int _player1Score;
        private int _player2Score;
        Dictionary<int, string> _scoreLookLike = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" },
        };
        

        public TennisGame(string player1Name)
        {
            _player1Name = player1Name;
        }

        public string GameResult()
        {
            if (_player1Score == _player2Score)
            {
                if (_player1Score >= 3 && _player2Score >= 3)
                {
                    return "Deuce";
                }
                return $"{_scoreLookLike[_player1Score]} All";
            }

            if (_player1Score >= 3 && Math.Abs(_player1Score - _player2Score) == 1)
            {
                return $"{_player1Name} Advantage";
            }

            return $"{_scoreLookLike[_player1Score]} {_scoreLookLike[_player2Score]}";
        }

        public void GivePlayer1ScoreTimes(int times)
        {
            for (int i = 0;i < times;i++)
            {
                _player1Score++;
            }
        }

        public void GivePlayer2ScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _player2Score++;
            }
        }
    }
}