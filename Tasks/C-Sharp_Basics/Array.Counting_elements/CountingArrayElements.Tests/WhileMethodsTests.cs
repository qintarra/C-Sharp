using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace CountingArrayElements.Tests
{
    [TestFixture]
    public sealed class WhileMethodsTests
    {
        private static readonly object[][] GetEmptyStringCountData =
        {
            new object[] { new[] { string.Empty, "abc", string.Empty, "def", string.Empty, "ghi", string.Empty }, 4 },
            new object[] { new[] { string.Empty, string.Empty, string.Empty }, 3 },
            new object[] { new[] { "ab", "cd", "ef", "gh", "ij", "kl", "mn" }, 0 },
            new object[] { new[] { "ab", string.Empty, "cd", "ef", "gh", "ij", "kl", "mn", string.Empty }, 2 },
        };

    }
}
