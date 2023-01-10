using NUnit.Framework;

namespace LeapYearTask.Tests
{
    [TestFixture]
    public class YearTests
    {

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
