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
            _tennis.GivePlayer1Score();
            GameResultShouldReturn("Fifteen Love");
        }

        private void GameResultShouldReturn(string expected)
        {
            var actual = _tennis.GameResult();
            actual.Should().Be(expected);
        }

    }
}
