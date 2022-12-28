using FluentAssertions;
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
            _tennis.GivePlayer1Score();
            ResultShouldBeReturn("Fifteen Love");
        }

        [Test]
        public void A03_Thirty_Love()
        {
            _tennis.GivePlayer1Score();
            _tennis.GivePlayer1Score();
            ResultShouldBeReturn("Thirty Love");
        }


        private void ResultShouldBeReturn(string result)
        {
            var actual = _tennis.GameResult();
            actual.Should().Be(result);
        }

    }
}
