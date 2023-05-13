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
        
        #region ArraysPlusOperator

        private static readonly object[] ArraysPlusOperator =
        {
            new object[]
            {
                new double[3, 4]
                {
                    {1, 2, 3, 4},
                    {1, 2, 3, 4},
                    {1, 2, 3, 4}
                },
                new double[3, 4]
                {
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                },
                new double[3, 4]
                {
                    {5, 5, 5, 5},
                    {5, 5, 5, 5},
                    {5, 5, 5, 5},
                }
            }
        };

        #endregion

        #region ArraysPlusAndMinusOperatorException

        private static readonly object[] ArraysPlusAndMinusOperatorException =
        {
            new object[] {new double[1, 0] { { } }, new double[0, 0] { }},
            new object[] {new double[1, 1] { { 1 } }, new double[1, 0] { { }}},
        };

        #endregion
        
        #region ArraysMinusOperator

        private static readonly object[] ArraysMinusOperator =
        {
            new object[]
            {
                new double[3, 4]
                {
                    {1, 2, 3, 4},
                    {1, 2, 3, 4},
                    {1, 2, 3, 4}
                },
                new double[3, 4]
                {
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                },
                new double[3, 4]
                {
                    {-3, -1, 1, 3},
                    {-3, -1, 1, 3},
                    {-3, -1, 1, 3},
                }
            }
        };

        #endregion
        
        #region ArraysOperatorMultiply

        private static readonly object[] ArraysOperatorMultiply =
        {
            new object[]
            {
                new double[0, 0] { }, new double[0, 0] { }, new double[0, 0] { }
            },
            
            new object[]
            {
                new double[2, 2] {{2, 2}, {2, 2}}, new double[2, 2] {{2, 2}, {2, 2}}, new double[2, 2] {{8, 8}, {8, 8}}
            },
            
            new object[]
            {
                new double[2, 3]
                {
                    {1, 4, 2},
                    {2, 5, 1}
                },
                new double[3, 3]
                {
                    {3, 4, 2},
                    {3, 5, 7},
                    {1, 2, 1}
                },
                new double[2, 3]
                {
                    {17, 28, 32},
                    {22, 35, 40}
                }
            },
            new object[]
            {
                new double[4, 3]
                {
                    {1, 2, 3},
                    {1, 2, 3},
                    {1, 2, 3},
                    {1, 2, 3}
                },
                new double[3, 4]
                {
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                    {4, 3, 2, 1},
                },
                new double[4, 4]
                {
                    {24, 18, 12, 6},
                    {24, 18, 12, 6},
                    {24, 18, 12, 6},
                    {24, 18, 12, 6}
                }
            }
        };
        
        #endregion
        
        #region ArraysOperatorMultiplyException

        private static readonly object[] ArraysOperatorMultiplyException =
        {
            new object[] {new double[0, 0] { }, new double[1, 0] {{ }}},
            new object[] {new double[1, 1] {{1}}, new double[0, 0] { }},
        };

        #endregion
        
        #endregion

        [TestCaseSource(nameof(ArraysCreateMatrix))]
        public void CreateMatrix_WithArray_PublicProperties_ReturnsCorrectValues(double[,] expectedArray)
        {
            // Arrange
            var expectedRows = expectedArray.GetLength(0);
            var expectedColumns = expectedArray.GetLength(1);

            // Act
            var matrix = new Matrix(expectedArray);

            // Assert
            Assert.AreEqual(expectedRows, matrix.Rows);
            Assert.AreEqual(expectedColumns, matrix.Columns);
        }
        
        [TestCase(3, 4)]
        [TestCase(5, 7)]
        [TestCase(7, 5)]
        public void CreateMatrix_WithDimensions_PublicProperties_ReturnsCorrectValues(int expectedRows,
            int expectedColumns)
        {
            // Act
            var matrix = new Matrix(expectedRows, expectedColumns);

            // Assert
            Assert.AreEqual(expectedRows, matrix.Rows);
            Assert.AreEqual(expectedColumns, matrix.Columns);
        }

        [TestCaseSource(nameof(ArraysCreateMatrix))]
        public void Indexer_GetEachElement_ShouldReturnValue(double[,] array)
        {
            // Arrange
            var matrix = new Matrix(array);

            // Act
            var isValid = true;
            for (var i = 0; i < matrix.Rows; i++)
            {
                for (var j = 0; j < matrix.Columns; j++)
                {
                    if (Math.Abs(matrix[i, j] - array[i, j]) > 0.001) isValid = false;
                }
            }

            // Assert
            Assert.AreEqual(true, isValid, message: "Indexer works incorrectly.");
        }

        [TestCase(4, 3)]
        [TestCase(3, 4)]
        public void Indexer_GetElementOutOfRange_ArgumentExceptionThrown(int rows, int columns)
        {
            // Arrange
            var matrix = new Matrix(rows, columns);
            var expectedException = typeof(ArgumentException);
            
            // Act
            var actException = Assert.Catch(() => _ = matrix[-10, -10]);

            // Assert
            Assert.AreEqual(expectedException, actException.GetType(),
                message: "Indexer should throw argument exception in case of nonexistent index.");
        }

        [TestCase(4, 3)]
        [TestCase(3, 4)]
        [TestCase(2, 2)]
        public void Indexer_SetElement_ShouldChangeValue(int rows, int columns)
        {
            // Arrange
            var matrix = new Matrix(rows, columns);
            const int expected1 = 1337;
            const int expected2 = 228;

            // Act
            matrix[rows - 1, columns - 1] = expected1;
            matrix[0, 0] = expected2;

            // Assert
            Assert.AreEqual(expected1, matrix[rows - 1, columns - 1],
                message: "Set property in indexer works incorrectly.");
            Assert.AreEqual(expected2, matrix[0, 0], message: "Set property in indexer works incorrectly.");
        }

        [TestCase(4, 3)]
        [TestCase(3, 4)]
        public void Indexer_SetElementOutOfRange_ArgumentExceptionThrown(int rows, int columns)
        {
            // Arrange
            var matrix = new Matrix(rows, columns);
            var expectedException = typeof(ArgumentException);

            // Act
            var actException = Assert.Catch(() => matrix[-1, -1] = 1337);

            // Assert
            Assert.AreEqual(expectedException, actException.GetType(), 
                message: "Set property in indexer should throw argument exception in case of nonexistent index.");
        }

        [TestCaseSource(nameof(ArraysOperatorMultiply))]
        public void Multiply_Matrix_ReturnsResultMatrix(double[,] array1, double[,] array2,
            double[,] expectedArray)
        {
            // Arrange
            var matrix1 = new Matrix(array1);
            var matrix2 = new Matrix(array2);
            var expected = new Matrix(expectedArray);

            // Act
            var actual = matrix1.Multiply(matrix2);

            // Assert
            Assert.AreEqual(expected.Array, actual.Array, "Multiply method works incorrectly.");
        }
        
        [TestCaseSource(nameof(ArraysPlusOperator))]
        public void Add_Matrix_ReturnsResultMatrix(double[,] array1, double[,] array2,
            double[,] expectedArray)
        {
            // Arrange
            var matrix1 = new Matrix(array1);
            var matrix2 = new Matrix(array2);
            var expected = new Matrix(expectedArray);

            // Act
            var actual = matrix1.Add(matrix2);

            // Assert
            Assert.AreEqual(expected.Array, actual.Array, message: "Add method works incorrectly.");
        }
        
        [TestCaseSource(nameof(ArraysMinusOperator))]
        public void Subtract_Matrix_ReturnsResultMatrix(double[,] array1, double[,] array2,
            double[,] expectedArray)
        {
            // Arrange
            var matrix1 = new Matrix(array1);
            var matrix2 = new Matrix(array2);
            var expected = new Matrix(expectedArray);

            // Act
            var actual = matrix1.Subtract(matrix2);

            // Assert
            Assert.AreEqual(expected.Array, actual.Array, message: "Subtract method works incorrectly.");
        }
        
        [TestCaseSource(nameof(ArraysCreateMatrix))]
        public void ToArray_ReturnsMatrixAsArray(double[,] expectedArray)
        {
            // Arrange
            var matrix = new Matrix(expectedArray);

            // Act
            var arrayMatrix = matrix.Array;

            Assert.AreEqual(expectedArray, arrayMatrix,
                message: "ToArray method returns array that is not equal to expected.");
        }

    }
}