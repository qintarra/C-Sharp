﻿namespace LeapYearTask
{
    public static class Year
    {
        /// <summary>
        /// Returns true if a specified <paramref name="year"/> is a leap year.
        /// </summary>
        /// <param name="year">A year to test.</param>
        /// <returns>True if a specified <paramref name="year"/> is a leap year; otherwise false.</returns>
        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
