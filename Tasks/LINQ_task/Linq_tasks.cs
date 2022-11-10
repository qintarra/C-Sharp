using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Objects;

namespace Linq
{
    public static class Tasks
    {
        public static string TaskExample(IEnumerable<string> stringList)
        {
            return stringList.Aggregate<string>((x, y) => x + y);
        }

        #region Low

        public static IEnumerable<string> Task1(char c, IEnumerable<string> stringList)
        {
            return stringList.Where(s => s.Length > 1 && s.First().Equals(c) && s.Last().Equals(c));
        }



        #endregion

    }
}
