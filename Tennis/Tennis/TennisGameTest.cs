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
