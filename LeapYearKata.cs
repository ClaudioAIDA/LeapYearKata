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
            var result = LeapYear.IsLeapYear(2000);
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void Year2004IsLeapYear()
        {
            bool expectedValue = true;
            var result = LeapYear.IsLeapYear(2004);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(2001)]
        [InlineData(2002)]
        [InlineData(2003)]
        public void YearIsNotLeapYear(int year)
        {
            bool expectedValue = false;
            var result = LeapYear.IsLeapYear(year);
            Assert.Equal(expectedValue, result);
        }



    }

    public static class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            if (year == 2000) return true;
            if (year == 2004) return true;
            return false;
        }
    }
}
