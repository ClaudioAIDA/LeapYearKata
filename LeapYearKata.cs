using System;
using Xunit;

namespace LeapYearKata
{
    public class LeapYearKataTest
    {

        [Theory]
        [InlineData(2000)]
        [InlineData(2004)]
        [InlineData(2008)]
        [InlineData(2400)]
        [InlineData(2800)]
        public void YearIsLeapYear(int year)
        {
            bool expectedValue = true;
            var result = LeapYear.IsLeapYear(year);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(2001)]
        [InlineData(2002)]
        [InlineData(2003)]
        [InlineData(2100)]
        [InlineData(2300)]
        [InlineData(2500)]
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
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            if (year % 4 == 0 ) return true;
            return false;
        }
    }
}
