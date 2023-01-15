﻿using NUnit.Framework;
using FluentAssertions;

namespace Tennis
{
    [TestFixture]
    public class TennisGameTest
    {
        private TennisGame _tennis;

        [SetUp]
        public void SetUp()
        {
            _tennis = new TennisGame();
        }
        [Test]
        public void A01_Love_All()
        {
            GameResultShouldReturn("Love All");
        }

        [Test]
        public void A02_Fifteen_Love()
        {
            _tennis.GivePlayer1ScoreTimes(1);
            GameResultShouldReturn("Fifteen Love");
        }

        [Test]
        public void A03_Thirty_Love()
        {
            _tennis.GivePlayer1ScoreTimes(2);
            GameResultShouldReturn("Thirty Love");
        }

        [Test]
        public void A04_Forty_Love()
        {
            _tennis.GivePlayer1ScoreTimes(3);
            GameResultShouldReturn("Forty Love");
        }

        [Test]
        public void A05_Love_Fifteen()
        {
            _tennis.GivePlayer2ScoreTimes(1);
            GameResultShouldReturn("Love Fifteen");
        }

        [Test]
        public void A06_Love_Thirty()
        {
            _tennis.GivePlayer2ScoreTimes(2);
            GameResultShouldReturn("Love Thirty");
        }

        [Test]
        public void A07_Love_Forty()
        {
            _tennis.GivePlayer2ScoreTimes(3);
            GameResultShouldReturn("Love Forty");
        }

        [Test]
        public void A08_Fifteen_All()
        {
            _tennis.GivePlayer1ScoreTimes(1);
            _tennis.GivePlayer2ScoreTimes(1);
            GameResultShouldReturn("Fifteen All");
        }
        [Test]
        public void A09_Thirty_All()
        {
            _tennis.GivePlayer1ScoreTimes(2);
            _tennis.GivePlayer2ScoreTimes(2);
            GameResultShouldReturn("Thirty All");
        }

        private void GameResultShouldReturn(string expected)
        {
            var actual = _tennis.GameResult();
            actual.Should().Be(expected);
        }

    }
}
