using System;
using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Score;
        private int _player2Score;
        Dictionary<int, string> _scoreLookLike = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" },
        };
        public string GameResult()
        {
            if (_player1Score != _player2Score)
            {
                return $"{_scoreLookLike[_player1Score]} {_scoreLookLike[_player2Score]}";
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

        public void GivePlayer2ScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _player2Score++;
            }
        }
    }
}