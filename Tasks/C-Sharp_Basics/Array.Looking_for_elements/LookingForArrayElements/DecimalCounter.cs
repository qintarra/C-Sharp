using System;
using System.Text;

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges)
        {
            // #5. Implement the method using "do..while" statements.
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges == null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            int count = 0;

            foreach (decimal[]?range in ranges)
            {
                if (range == null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }

                if (range.Length != 2)
                {
                    throw new ArgumentException("Range array must have exactly two elements.", nameof(ranges));
                }

                decimal rangeStart = range[0];
                decimal rangeEnd = range[1];

                if (rangeStart > rangeEnd)
                {
                    throw new ArgumentException("Range start value must be less than or equal to range end value.", nameof(ranges));
                }

                foreach (decimal value in arrayToSearch)
                {
                    if (value >= rangeStart && value <= rangeEnd)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges, int startIndex, int count)
        {
            // #6. Implement the method using "for" statement.

        }
    }
}
