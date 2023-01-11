using NUnit.Framework;

namespace DartsGame.Tests
{
    [TestFixture]
    public class DartsTests
    {
        [Test]
        public void GetScore_DartLandsOutsideTheTarget_Return_0()
        {
            Assert.AreEqual(0, Darts.GetScore(-9, 9));
        }

        [Test]
        public void GetScore_DartLandsJustInTheBorderOfTheTarget_Return_1()
        {
            Assert.AreEqual(1, Darts.GetScore(0, 10));
        }

    }
}
