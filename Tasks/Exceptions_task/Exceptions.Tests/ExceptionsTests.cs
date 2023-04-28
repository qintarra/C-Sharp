using System;
using NUnit.Framework;

namespace Exceptions.Tests
{
    [TestFixture]
    public class Tests
    {
        #region Startup Data

        #region ArraysCreateMatrix

        private static readonly object[] ArraysCreateMatrix =
        {
            new object[] {new double[0, 0] { }},
            new object[]
            {
                new double[3, 4]
                {
                    {1, 2, 3, 4},
                    {1, 2, 3, 4},
                    {1, 2, 3, 4}
                }
            }
        };

        #endregion
        
        #endregion


    }
}