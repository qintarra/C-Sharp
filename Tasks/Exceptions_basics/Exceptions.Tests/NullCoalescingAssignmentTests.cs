namespace Exceptions.Tests
{
    public class NullCoalescingAssignmentTests
    {
        [Test]
        public void CheckParameterAndThrowException1_O_IsNull_ReturnsObject()
        {
            // Act
            object actualResult = NullCoalescingAssignment.CheckParameterAndThrowException1(null);

            // Assert
            Assert.IsNotNull(actualResult);
        }

        [Test]
        public void CheckParameterAndThrowException1_O_IsNotNull_ReturnsObject()
        {
            // Arrange
            object o = new object();

            // Act
            object actualResult = NullCoalescingAssignment.CheckParameterAndThrowException1(o);

            // Assert
            Assert.IsNotNull(actualResult);
            Assert.AreSame(o, actualResult);
        }

        [Test]
        public void CheckParameterAndThrowException2_IntegersIsNull_ReturnsArray()
        {
            // Act
            int[] actualResult = NullCoalescingAssignment.CheckParameterAndThrowException2(null);

            // Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(new int[] { 0 }, actualResult);
        }

        [Test]
        public void CheckParameterAndThrowException2_IntegersIsNotNull_ReturnsArray()
        {
            // Arrange
            int[] integers = new int[] { 1, 2, 3 };

            // Act
            int[] actualResult = NullCoalescingAssignment.CheckParameterAndThrowException2(integers);

            // Assert
            Assert.IsNotNull(actualResult);
            Assert.AreSame(integers, actualResult);
        }

    }
}
