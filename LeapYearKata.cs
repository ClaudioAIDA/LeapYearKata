using System;
using Xunit;

namespace LeapYearKata
{
    public class LeapYearKataTest
    {
        [Fact]
        public void Year2000IsLeapYear()
        {
            bool expectedValue = true;
            var result = LeapYear.isLeapYear(2000);
            Assert.Equal(expectedValue, result);
        }
    }

    public static class LeapYear
    {
        public static bool isLeapYear(int year)
        {
            return true;
        }
    }
}
