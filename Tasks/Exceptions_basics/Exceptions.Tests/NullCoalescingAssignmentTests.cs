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

    }
}
