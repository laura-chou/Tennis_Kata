using FluentAssertions;
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
            _tennis.GivePlayer1Score();
            ScoreResultShouldReturn("Fifteen Love");
        }

        private void ScoreResultShouldReturn(string expected)
        {
            var actual = _tennis.ScoreResult();
            actual.Should().Be(expected);
        }
    }
}
