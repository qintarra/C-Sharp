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
  }
}
