using FluentAssertions;
using NUnit.Framework;

namespace Tennis
{
    [TestFixture]
    class TennisGameTest
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
