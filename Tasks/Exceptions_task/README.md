## Exceptions

### Task Matrix

Create type **Matrix**, which encapsulates a two-dimensional array-matrix block of real (double) type.    

Matrix is the cover for a two-dimensional array of real values, storing matrix values with operations of matrix addition, deduction, and multiplication.  

Real type values (double) can be in a matrix, specifying during creation, the number of array rows and columns, which will store these values. After creation, the number of rows and columns is not changed. Values to matrix elements can be set while creating a matrix, and later with the help of an indexer.  

A matrix can provide information regarding the number of array rows and columns, receive array elements in a standard two-dimensional array, and add, deduct and multiply matrixes compatible by size. If a user is trying to perform operations with a matrix of incompatible sizes – user type exceptions **MatrixException** are thrown from operations. Other matrix methods also throw exceptions, if a user applies them incorrectly (conveys incorrect parameters into the constructor, in indexer – non-existing index, and so on).  

Matrices can be cloned and compared with one another (content encapsulated in a matrix array is used for comparison).

The task has two levels of complexity: low and advanced.

### The low level requires implementation of the following functionality:  

In **Matrix** it requires the implementation of the following functionality:  
- Creating an empty matrix with a predetermined number of rows and columns (all values in the matrix equal 0).  
- Creating of matrix based on an existing two-dimensional array.  
- Receiving a number of matrix rows and columns.  
- Receiving of standard two-dimensional array out of the matrix.  
- Access to recording and reading of elements via predetermined correct index (indexer).  
- Method of matrices addition.  
- Method of matrices subtraction.  
- Method of matrices multiplication.  
- Raise exceptions specified in XML comments to class methods (standard and user).  

### The advanced level requires implementation of the following functionality:  

