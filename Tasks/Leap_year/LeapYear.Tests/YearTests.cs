using NUnit.Framework;

namespace LeapYearTask.Tests
{
    [TestFixture]
    public class YearTests
    {
        [TestCase(2015)]
        [TestCase(1970)]
        [TestCase(2100)]
        [TestCase(1800)]
        [TestCase(1234)]
        public void IsLeapYear_ReturnFalse(int year)
        {
            Assert.False(Year.IsLeapYear(year));
        }

        public void IsLeapYear_ReturnTrue(int year)
        {
            Assert.True(Year.IsLeapYear(year));
        }
    }
}
