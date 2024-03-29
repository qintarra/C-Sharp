# Delegates and events

This task refers to task [Collections](https://github.com/Qintarra/C-Sharp/tree/main/Tasks/Collections_task)

## Task Collections
<details>
<summary>Collections description</summary>

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

</details>

## Task Events

Add the following new functionalities to the project created in task Collections: 

Include two events in the **CustomArray** type: 

- The **OnChangeElement** event occurs when the indexer changes the element value (if the old and new element values match, the event is not raised) 

- The **OnChangeEqualElement** event occurs if a value equal to the index of the changed element is written to the element (if the old and new values of the element match, the event is not raised) 
 
Use the **ArrayHandler** delegate to create the event. 

The event handler takes two parameters: an object **sender** - a reference to the **CustomArray** instance that generated the event, and an event argument **ArrayEventArgs <T> e**. In the event argument, write in the **Id** field the index by which the user changes the element of the **CustomArray** array, in the **Value** field - the new value of the element by the Id index, in the **Message** field - an arbitrary string message. 
