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
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when row or column is zero or negative.</exception>
        

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class with the specified elements.
        /// </summary>
        /// <param name="array">An array of floating-point values that represents the elements of this Matrix.</param>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
       

        /// <summary>
        /// Allows instances of a <see cref="Matrix"/> to be indexed just like arrays.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <exception cref="ArgumentException">Thrown when index is out of range.</exception>
        

        /// <summary>
        /// Adds <see cref="Matrix"/> to the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for adding.</param>
        /// <exception cref="ArgumentNullException">Thrown when parameter is null.</exception>
        /// <exception cref="MatrixException">Thrown when the matrix has the wrong dimensions for the operation.</exception>
        /// <returns><see cref="Matrix"/></returns>
        

        /// <summary>
        /// Subtracts <see cref="Matrix"/> from the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for subtracting.</param>
        /// <exception cref="ArgumentNullException">Thrown when parameter is null.</exception>
        /// <exception cref="MatrixException">Thrown when the matrix has the wrong dimensions for the operation.</exception>
        /// <returns><see cref="Matrix"/></returns>
        

        /// <summary>
        /// Multiplies <see cref="Matrix"/> on the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for multiplying.</param>
        /// <exception cref="ArgumentNullException">Thrown when parameter is null.</exception>
        /// <exception cref="MatrixException">Thrown when the matrix has the wrong dimensions for the operation.</exception>
        /// <returns><see cref="Matrix"/></returns>
        
    }
}