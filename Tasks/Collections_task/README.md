## Collections, generics  

### Custom array

Create generic type **CustomArray** – one-dimensional array with a random index range  

**CustomArray** is a collection – array of random type values with fixed length and an original index that the user specifies.  

Example 1: an array of 20 elements length, array values – symbols, the index starts with 18.  

Example 2: an array of 10 elements length, array values – objects of class Animals, the index starts with -5.  

Values of random type can be located in the array, custom first index and the number of elements in the array should be specified while creating. The length and range of indexes cannot be changed after creating. Values of array elements can be set while creating the array and later with the help of the indexer.  

Initial and finite index, array length, and array elements in a standard array Array that starts with 0 can be obtained from the array.

CustomArray should be able to use operator 'foreach' and other constructions that are oriented to the presence of a numerator in class.

In **CustomArray** implementation of the following functionality is required:  
- Creating of empty user array with a specified first index and a specified number of elements.  
- Creating of user array based on a standard existing array or other collection.  
- Creating an array with the specified first index based on the values of the array params.  
- Receiving first, last indexes, length, and values in form of a standard array with first index 0.  
- Access to writing and reading element based on a predetermined correct index.  
- Generating exceptions, specified in XML comments to class methods.  
- Receiving numerator from an array for operator 'foreach'.