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
            _tennis = new TennisGame("Player A", "Player B");
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

        [Test]
        public void A10_Deuce()
        {
            _tennis.GivePlayer1ScoreTimes(3);
            _tennis.GivePlayer2ScoreTimes(3);
            GameResultShouldReturn("Deuce");
        }

        [Test]
        public void A11_Deuce_4vs4()
        {
            _tennis.GivePlayer1ScoreTimes(4);
            _tennis.GivePlayer2ScoreTimes(4);
            GameResultShouldReturn("Deuce");
        }

        [Test]
        public void A12_Player1_Advantage()
        {
            _tennis.GivePlayer1ScoreTimes(5);
            _tennis.GivePlayer2ScoreTimes(4);
            GameResultShouldReturn("Player A Advantage");
        }

        [Test]
        public void A13_Player2_Advantage()
        {
            _tennis.GivePlayer1ScoreTimes(4);
            _tennis.GivePlayer2ScoreTimes(5);
            GameResultShouldReturn("Player B Advantage");
        }

        [Test]
        public void A14_Player1_Win()
        {
            _tennis.GivePlayer1ScoreTimes(5);
            _tennis.GivePlayer2ScoreTimes(3);
            GameResultShouldReturn("Player A Win");
        }

        [Test]
        public void A15_Player2_Win()
        {
            _tennis.GivePlayer1ScoreTimes(3);
            _tennis.GivePlayer2ScoreTimes(5);
            GameResultShouldReturn("Player B Win");
        }

        private void GameResultShouldReturn(string expected)
        {
            var actual = _tennis.GameResult();
            actual.Should().Be(expected);
        }

    }
}
