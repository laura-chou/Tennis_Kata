using NUnit.Framework;
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

        private void GameResultShouldReturn(string expected)
        {
            var actual = _tennis.GameResult();
            actual.Should().Be(expected);
        }

    }
}
