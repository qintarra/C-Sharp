using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    public class MatrixException : Exception
    {
        public MatrixException() { }

        public MatrixException(string message) : base(message) { }

        public MatrixException(string message, Exception innerException) : base(message, innerException) { }

        protected MatrixException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
    public class Matrix
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
                    
                if(column < 0 || column >= Columns)
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
        /// Adds <see cref="Matrix"/> to the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for adding.</param>
        /// <exception cref="ArgumentNullException">Thrown when parameter is null.</exception>
        /// <exception cref="MatrixException">Thrown when the matrix has the wrong dimensions for the operation.</exception>
        /// <returns><see cref="Matrix"/></returns>
        public Matrix Add(Matrix matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException("matrix");
            }
            else
            {
                if (Rows != matrix.Rows || Columns != matrix.Columns)
                {
                    throw new MatrixException();
                }
                else
                {
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = 0; j < Columns; j++)
                        {
                            matrix[i, j] += Array[i, j];
                        }
                    }
                    return matrix;
                }
            }
        }

        /// <summary>
        /// Subtracts <see cref="Matrix"/> from the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for subtracting.</param>
        /// <exception cref="ArgumentNullException">Thrown when parameter is null.</exception>
        /// <exception cref="MatrixException">Thrown when the matrix has the wrong dimensions for the operation.</exception>
        /// <returns><see cref="Matrix"/></returns>
        public Matrix Subtract(Matrix matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException("matrix");
            }
            else
            {
                if (Rows != matrix.Rows || Columns != matrix.Columns)
                {
                    throw new MatrixException();
                }
                else
                {
                    double[,] matrix2 = new double[Rows, Columns];
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = 0; j < Columns; j++)
                        {
                            matrix2[i, j] = Array[i, j] - matrix.Array[i,j];
                        }
                    }
                    return new Matrix(matrix2);
                }
            }
        }

        /// <summary>
        /// Multiplies <see cref="Matrix"/> on the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for multiplying.</param>
        /// <exception cref="ArgumentNullException">Thrown when parameter is null.</exception>
        /// <exception cref="MatrixException">Thrown when the matrix has the wrong dimensions for the operation.</exception>
        /// <returns><see cref="Matrix"/></returns>
        public Matrix Multiply(Matrix matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException("matrix");
            }
            if (Columns != matrix.Rows)
                {
                    throw new MatrixException();
                }
            double[,] matrix3 = new double[Rows, matrix.Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    for (int h = 0; h < Columns; h++)
                    {
                        matrix3[i, j] += Array[i, h] * matrix[h, j];
                    }
                }
            }
            return new Matrix(matrix3);
        }
    }
}