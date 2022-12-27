using FluentAssertions;
using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    class TennisGameTest
    {
        TennisGame _tennis;

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
            _tennis.GivePlayer1Score();
            ResultShouldBeReturn("Fifteen Love");
        }

        private void ResultShouldBeReturn(string result)
        {
            var actual = _tennis.GameResult();
            actual.Should().Be(result);
        }

    }
}
