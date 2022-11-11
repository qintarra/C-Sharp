# LINQ

Write LINQ queries using extension methods. Each task must be solved with
one LINQ query. Put LINQ expression in the return statement (Look at the template at the end of the task before solving the problem)

## Part Low 

At the Low level, you need to solve the following five tasks:

### Task 1
The character **C** and a sequence of non-empty strings **stringList** are given.
Get a new sequence of strings with more than one character from the **stringList**, starting and
ending with C.

### Task 2
A sequence of non-empty strings **stringList** is given.
Get a sequence of ascending sorted integer values equal to the lengths of the strings included
in the **stringList** sequence.

### Task 3
A sequence of non-empty strings **stringList** is given.
Get a new sequence of strings, where each string consists of the first and last characters of the
corresponding string in the **stringList** sequence.

### Task 4
A positive integer **K** and a sequence of non-empty strings **stringList** are given. Strings of the
sequence contains only numbers and capital letters of the Latin alphabet.
Get from **stringList** all strings of length **K** ending in a digit and sort them in ascending order.

### Task 5
A sequence of positive integer values **integerList** is given.
Get a sequence of string representations of only odd **integerList** values and sort in ascending
order.

## Part Middle

At the Middle level, you need to solve the following five tasks:

### Task 6

A sequence of positive integers **numbers** and a sequence of strings **stringList** are given.
Get a new sequence of strings according to the following rule: for each value **n** from sequence
**numbers**, select a string from the sequence **stringList** that starts with a digit and has length **n**. If
there are several required strings in the **stringList** sequence, return the first; if there are none,
then return the string "Not found" (To handle the situation related to the absence of required
strings, use the ?? operation)

### Task 7
You are given a positive integer **K** and a sequence of integers **integerList**.
Calculate the difference between two subsets of integer values: the first subset is even
**integerList** values, the second subset is the integerList values excluding the first **K** elements.
In the resulting difference, replace the order with the reversed.

### Task 8
A positive integer **K**, an integer **D**, and a sequence of integers **integerList** are given.
Compute the union of two subsets of integers: the first subset is all **integerList** values up to
and excluding the first element greater than **D**, and the second subset is the **integerList** values
starting with the element with ordinal number **K** inclusive (**integerList** element numbering
starts at 0). Sort the resulting sequence in descending order.


## An example of solving a LINQ task

**Task** 

Given a sequence of non-empty strings **stringList**. Get a new 
string by concatenating all strings from **stringList**.

Consider that the values have already been set for **stringList**, and the assignment of new values is an error.
Return the result of solving the problem via the function.

```
public static string LinqSample(IEnumerable<string> stringList)
{
        return stringList.Aggregate<string>((x, y) => x + y);
}
```
