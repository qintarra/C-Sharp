using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Extension
{
    public static class MyExtension
    {
        /// <summary>
        /// Mehod that return sum of  'n' digit
        /// </summary>        
        /// <param name="n">Element parameter</param>
        /// <returns>Integer value</returns>
        public static int SummaDigit(this int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
       
        /// <summary>
        /// Method that return sum of 'n' element and reverse of 'n'
        /// </summary>
        /// <param name="n">Element parameter</param>
        /// <returns>Ulong value</returns>
        public static ulong SummaWithReverse(this uint n)
        {
            uint nReverse = uint.Parse(n.ToString().Reverse().ToArray());
            return n + nReverse;
        }
       
        /// <summary>
        /// Method that count amount of elements in string , which are not letters of the latin alphabet.
        /// </summary>
        /// <param name="str">String parameter</param>
        /// <returns>Integer value</returns>


      
        /// <summary>
        /// Method that checks whether day is weekend or not 
        /// </summary>
        /// <param name="day">DayOfWeek parameter</param>
        /// <returns>Bool value</returns>


       
        /// <summary>
        /// Method that return positive ,even  element from collection 
        /// </summary>
        /// <param name="numbers">Collection of elements</param>
        /// <returns>IEnumerable -int collection  </returns>

    }
}
