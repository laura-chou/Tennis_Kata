using FluentAssertions;
using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    public class TennisGameTest
    {
        [Test]
        public void A01_Love_All()
        {
            var tennis = new TennisGame();
            var actual = tennis.ScoreResult();
            actual.Should().Be("Love All");
        }
    }
}
