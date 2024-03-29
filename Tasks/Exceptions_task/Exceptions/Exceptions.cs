﻿using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    // Create custom exception "MatrixException"
    [Serializable]
    public class MatrixException : Exception
    {
        public MatrixException() { }

        public MatrixException(string message) : base(message) { }

        public MatrixException(string message, Exception innerException) : base(message, innerException) { }

        protected MatrixException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
	
    public class Matrix : ICloneable
    {
        /// <summary>
        /// Number of rows.
        /// </summary>
        public int Rows
        {
            get;
        }

        /// <summary>
        /// Number of columns.
        /// </summary>
        public int Columns
        {
            get;
        }

        /// <summary>
        /// An array of floating-point values that represents the elements of this Matrix.
        /// </summary>
        public double[,] Array
        {
            get;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when row or column is zero or negative.</exception>
        public Matrix(int rows, int columns)
        {
            if (rows <= 0)
            {
                throw new ArgumentOutOfRangeException("rows");
            }

            if (columns <= 0)
            {
                throw new ArgumentOutOfRangeException("columns");
            }

            Array = new double[rows, columns];
            Rows = rows;
            Columns = columns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class with the specified elements.
        /// </summary>
        /// <param name="array">An array of floating-point values that represents the elements of this Matrix.</param>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        public Matrix(double[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            Rows = array.GetLength(0);
            Columns = array.GetLength(1);
            Array = array;
        }

        /// <summary>
        /// Allows instances of a <see cref="Matrix"/> to be indexed just like arrays.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <exception cref="ArgumentException">Thrown when index is out of range.</exception>
        public double this[int row, int column]
        {
            get
            {
                if (row < 0 || row >= Rows)
                {
                    throw new ArgumentException("row");
                }
                    
                if (column < 0 || column >= Columns)
                {
                    throw new ArgumentException("column");
                }
                    
                return Array[row, column];
            }
            set
            {
                if (row < 0 || row >= Rows)
                {
                    throw new ArgumentException("row");
                }

                if (column < 0 || column >= Columns)
                {
                    throw new ArgumentException("column");
                }

                Array[row, column] = value;
            }
        }	
		
        /// <summary>
        /// Creates a deep copy of this Matrix.
        /// </summary>
        /// <returns>A deep copy of the current object.</returns>
        public object Clone()
        {
            double[,] newArray = new double[Rows, Columns];

            // Copy elements to new array
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    newArray[i, j] = Array[i, j];
                }
            }

            // Create new matrix using new array
            Matrix newMatrix = new Matrix(newArray);
            return newMatrix;
        }
				
        /// <summary>
        /// Adds two matrices.
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns>New <see cref="Matrix"/> object which is sum of two matrices.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 == null)
            {
                throw new ArgumentNullException(nameof(matrix1));
            }

            if (matrix2 == null)
            {
                throw new ArgumentNullException(nameof(matrix2));
            }

            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                throw new MatrixException("Matrices must have the same dimensions.");
            }

            Matrix resultPlus = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    resultPlus[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return resultPlus;
        }
			
        /// <summary>
        /// Subtracts two matrices.
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns>New <see cref="Matrix"/> object which is subtraction of two matrices</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 == null)
            {
                throw new ArgumentNullException(nameof(matrix1));
            }

            if (matrix2 == null)
            {
                throw new ArgumentNullException(nameof(matrix2));
            }

            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                throw new MatrixException("Matrices must have the same dimensions.");
            }

            Matrix resultMinus = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    resultMinus[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return resultMinus;
        }
		
		/// <summary>
        /// Multiplies two matrices.
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns>New <see cref="Matrix"/> object which is multiplication of two matrices.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 == null)
            {
                throw new ArgumentNullException(nameof(matrix1));
            }

            if (matrix2 == null)
            {
                throw new ArgumentNullException(nameof(matrix2));
            }

            if (matrix1.Columns != matrix2.Rows)
            {
                throw new MatrixException("Number of columns of the first matrix must be equal to the number of rows of the second matrix.");
            }

            Matrix resultMultiply = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Columns; j++)
                {
                    double sum = 0;

                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }

                    resultMultiply[i, j] = sum;
                }
            }

            return resultMultiply;
        }

        /// <summary>
        /// Adds <see cref="Matrix"/> to the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for adding.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public Matrix Add(Matrix matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            if (Rows != matrix.Rows || Columns != matrix.Columns)
            {
                throw new MatrixException("The matrices must have the same number of rows and columns.");
            }

            return this + matrix;
        }

        /// <summary>
        /// Subtracts <see cref="Matrix"/> from the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for subtracting.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public Matrix Subtract(Matrix matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            if (Rows != matrix.Rows || Columns != matrix.Columns)
            {
                throw new MatrixException("The matrices must have the same number of rows and columns.");
            }

            return this - matrix;
        }

        /// <summary>
        /// Multiplies <see cref="Matrix"/> on the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for multiplying.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="MatrixException"></exception>
        public Matrix Multiply(Matrix matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            if (Columns != matrix.Rows)
            {
                throw new MatrixException("Number of columns of the first matrix must be equal to the number of rows of the second matrix.");
            }

            Matrix resultMultiply = new Matrix(Rows, matrix.Columns);

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    double sum = 0;

                    for (int k = 0; k < Columns; k++)
                    {
                        sum += this[i, k] * matrix[k, j];
                    }

                    resultMultiply[i, j] = sum;
                }
            }

            return resultMultiply;
        }
			
        /// <summary>
        /// Tests if <see cref="Matrix"/> is identical to this Matrix.
        /// </summary>
        /// <param name="obj">Object to compare with. (Can be null)</param>
        /// <returns>True if matrices are equal, false if are not equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj is not Matrix)
            {
                return false;
            }

            Matrix otherMatrix = (Matrix)obj;

            if (otherMatrix.Rows != Rows || otherMatrix.Columns != Columns)
            {
                return false;
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (otherMatrix[i, j] != this[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
		
        public override int GetHashCode() => GetHashCode();
    }
}