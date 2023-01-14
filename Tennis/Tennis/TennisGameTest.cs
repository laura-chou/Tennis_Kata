﻿using NUnit.Framework;
using FluentAssertions;

namespace Tennis
{
    [TestFixture]
    public class TennisGameTest
    {
        [Test]
        public void A01_Love_All()
        {
            var tennis = new TennisGame();
            var actual = tennis.GameResult();
            actual.Should().Be("Love All");
        }

        [Test]
        public void A02_Fifteen_Love()
        {
            var tennis = new TennisGame();
            tennis.GivePlayer1Score();
            var actual = tennis.GameResult();
            actual.Should().Be("Fifteen Love");
        }
    }
}
