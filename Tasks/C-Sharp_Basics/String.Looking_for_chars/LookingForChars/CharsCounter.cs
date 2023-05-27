﻿using System;

namespace LookingForChars
{
    public static class CharsCounter
    {
        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <returns>The number of occurrences of all characters.</returns>
        public static int GetCharsCount(string? str, char[]? chars)
        {
            // 1. Implement the method using "for" statement.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (Array.IndexOf(chars, str[i]) != -1)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex)
        {
            // 2. Implement the method using "while" statement.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (startIndex < 0 || startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < 0 || endIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentException("startIndex is greater than endIndex.");
            }

            int count = 0;
            int i = startIndex;

            while (i <= endIndex)
            {
                if (Array.IndexOf(chars, str[i]) != -1)
                {
                    count++;
                }

                i++;
            }

            return count;
        }

        /// <summary>
        /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <param name="limit">A maximum number of characters to search.</param>
        /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex, int limit)
        {
            // 3. Implement the method using "do..while" statements.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (startIndex < 0 || startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < 0 || endIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentException("startIndex is greater than endIndex.");
            }

            if (limit < 0 || limit >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(limit));
            }

            int count = 0;

            int i = startIndex;
            do
            {
                if (Array.IndexOf(chars, str[i]) != -1)
                {
                    count++;
                }

                i++;
            }
            while (count < limit && i <= endIndex);

            return count;
        }
    }
}
