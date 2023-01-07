﻿using FluentAssertions;
using NUnit.Framework;

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
            ScoreResultShouldReturn("Love All");
        }

        [Test]
        public void A02_Fifteen_Love()
        {
            GivePlayer1ScoreTimes(1);
            ScoreResultShouldReturn("Fifteen Love");
        }

        [Test]
        public void A03_Thirty_Love()
        {
            GivePlayer1ScoreTimes(2);
            ScoreResultShouldReturn("Thirty Love");
        }

        [Test]
        public void A04_Forty_Love()
        {
            GivePlayer1ScoreTimes(3);
            ScoreResultShouldReturn("Forty Love");
        }

        [Test]
        public void A05_Love_Fifteen()
        {
            GivePlayer2ScoreTimes(1);
            ScoreResultShouldReturn("Love Fifteen");
        }

        [Test]
        public void A06_Love_Thirty()
        {
            GivePlayer2ScoreTimes(2);
            ScoreResultShouldReturn("Love Thirty");
        }

        private void ScoreResultShouldReturn(string expected)
        {
            var actual = _tennis.ScoreResult();
            actual.Should().Be(expected);
        }

        private void GivePlayer1ScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.GivePlayer1Score();
            }
        }

        private void GivePlayer2ScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.GivePlayer2Score();
            }
        }
    }
}
