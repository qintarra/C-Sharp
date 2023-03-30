# For Statements


## Task Description

The task has sixteen tasks in six sections. Each task is a small coding exercise.

Use the only `for` and `if-else` statements in this task. Using `while` or `do-while` iteration statements is not required.


### Arithmetic Sequences

The arithmetic sequence formula is given as,

$a_{n} = a+(n-1)\cdot{d}$

where,
* $a_{n}$ is the nth term,
* $a$ is the first term, and
* $d$ is the common difference.

#### Task 1

Open the [ArithmeticSequences.cs](ForStatements/ArithmeticSequences.cs) file.

Implement the method that returns sum of an arithmetic sequence terms if the common difference is 1.

$\sum_{i=1}^{n} a+(i-1)\cdot{1}=\sum_{i=0}^{n-1} a+i$

For the arithmetic sequence ${5, 6, 7, 8, 9, ...}$ the sum of the first five elements is 35 (5 + 6 + 7 + 8 + 9).

The algorithm you have to implement is shown on the flowchart diagram below. The flowchart notation has no special symbol for a `for` statement, therefore a decision block is used in the diagram.

![Arithmetic Sequence 1 Diagram](images/as-1.png)

Read and analyze the diagram, add the code to the _SumArithmeticSequenceTerms1_ method. 

1. Declare and initialize the _sum_ and the _i_ variables. Add the *return* statement  

```cs
public static int SumArithmeticSequenceTerms1(int a, int n)
{
    int sum = 0;

    return sum;
}
```
