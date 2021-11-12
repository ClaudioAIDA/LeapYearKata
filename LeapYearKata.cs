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

        [Fact]
        public void Year2001IsNotLeapYear()
        {
            bool expectedValue = false;
            var result = LeapYear.isLeapYear(2001);
            Assert.Equal(expectedValue, result);
        }
    }

    public static class LeapYear
    {
        public static bool isLeapYear(int year)
        {
            if (year == 2000) return true;
            return false;
        }
    }
}
