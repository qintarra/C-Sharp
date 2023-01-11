﻿using NUnit.Framework;

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

        [Test]
        public void GetScore_DartLandsInTheOuterCircle_Return_4()
        {
            Assert.AreEqual(1, Darts.GetScore(4, 4));
        }

        [Test]
        public void GetScore_DartLandsRightIinTheBorderBetweenOuterAndMiddleCircles_Return_5()
        {
            Assert.AreEqual(5, Darts.GetScore(5, 0));
        }

    }
}
