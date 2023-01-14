using NUnit.Framework;
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
    }
}
