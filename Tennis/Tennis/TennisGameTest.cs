﻿using FluentAssertions;
using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    class TennisGameTest
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
            ResultShouldBeReturn("Love All");
        }

        [Test]
        public void A02_Fifteen_Love()
        {
            GivenPlayer1ScoreTimes(1);
            ResultShouldBeReturn("Fifteen Love");
        }

        [Test]
        public void A03_Thirty_Love()
        {
            GivenPlayer1ScoreTimes(2);
            ResultShouldBeReturn("Thirty Love");
        }

        [Test]
        public void A04_Forty_Love()
        {
            GivenPlayer1ScoreTimes(3);
            ResultShouldBeReturn("Forty Love");
        }

        [Test]
        public void A05_Love_Fifteen()
        {
            GivenPlayer2ScoreTimes(1);
            ResultShouldBeReturn("Love Fifteen");
        }

        [Test]
        public void A06_Love_Thirty()
        {
            GivenPlayer2ScoreTimes(2);
            ResultShouldBeReturn("Love Thirty");
        }

        [Test]
        public void A07_Love_Forty()
        {
            GivenPlayer2ScoreTimes(3);
            ResultShouldBeReturn("Love Forty");
        }

        [Test]
        public void A08_Deuce()
        {
            GivenPlayer1ScoreTimes(3);
            GivenPlayer2ScoreTimes(3);
            ResultShouldBeReturn("Deuce");
        }

        [Test]
        public void A09_Deuce_4vs4()
        {
            GivenPlayer1ScoreTimes(4);
            GivenPlayer2ScoreTimes(4);
            ResultShouldBeReturn("Deuce");
        }

        private void ResultShouldBeReturn(string result)
        {
            var actual = _tennis.GameResult();
            actual.Should().Be(result);
        }

        private void GivenPlayer1ScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.GivePlayer1Score();
            }
        }
        private void GivenPlayer2ScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.GivePlayer2Score();
            }
        }
    }
}
