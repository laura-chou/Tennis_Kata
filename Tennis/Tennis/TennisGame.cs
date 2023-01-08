﻿using System;
using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Score;
        private int _player2Score;
        private Dictionary<int, string> _scoreLookLike = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };
        private readonly string _player1Name;

        public TennisGame(string player1Name)
        {
            _player1Name = player1Name;
        }

        public string ScoreResult()
        {
            if (_player1Score != _player2Score )
            {
                if(_player1Score >= 3 && Math.Abs(_player1Score - _player2Score) == 1)
                {
                    return $"{_player1Name} Advantage";
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