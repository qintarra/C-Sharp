# While Statements


## Task Description

The task has fifteen sub-tasks in five sections. Each sub-task is a small coding exercise.  

Use the only *while* and *if-else* statements in this task. Using *for* or *do-while* iteration statements is not required.  


### Arithmetic Sequences

An *arithmetic sequence* is an ordered set of terms (numbers) that have a common difference between each consecutive term.

The arithmetic sequence formula is given as  

$a_{n} = a+(n-1)*d$   

where   
- $a_{n}$ is the nth term,
- $a$ is the first term, and
- d is the *common difference*

#### Sub-task 1

Open the [ArithmeticSequences.cs](WhileStatements/ArithmeticSequences.cs) file.

Implement the method that returns sum of an arithmetic sequence terms if the common difference is 1.

$$\sum_{i=1}^{n} a+(i-1)*1=\sum_{i=0}^{n-1} a+i$$

For the arithmetic sequence ${5, 6, 7, 8, 9, ...}$ the sum of the first five elements is 35 (5 + 6 + 7 + 8 + 9).

The algorithm you have to implement is shown on the flowchart diagram below. The flowchart notation has no special symbol for a _while_ statement, therefore a decision block is used it.

![Arithmetic Sequence 1 Diagram](images/as-1.png)

Read and analyze the diagram, add the code to the _SumArithmeticSequenceTerms1_ method. 

#### Sub-task 2

Open the [ArithmeticSequences.cs](WhileStatements/ArithmeticSequences.cs) file.

Implement the method that returns the sum of an arithmetic sequence elements when the first term is 17 and the common difference is 33.

$$\sum_{i=1}^{n} 17+(i-1)*33=\sum_{i=0}^{n-1} 17+i*33$$

Beginner programmers often put number literals in their code like this:

```cs
public static int SumArithmeticSequenceTerms2(int n)
{
    int sum = 0, i = 0;

    while (i < n)
    {
        sum += 17 + (i * 33);
        i++;
    }

    return sum;
}
```

Experienced programmers consider using number literals with unexplained meaning as a *bad practice*. They call such literals [magic numbers](https://en.wikipedia.org/wiki/Magic_number_(programming)).

If you have a magic number in your code, [replace it with a symbolic constant](https://refactoring.guru/replace-magic-number-with-symbolic-constant):

```cs
public static int SumArithmeticSequenceTerms2(int n)
{
    const int firstTerm = 17;
    const int commonDifference = 33;

    int sum = 0, i = 0;

    while (i < n)
    {
        sum += firstTerm + (i * commonDifference);
        i++;
    }

    return sum;
}
```

#### Sub-task 3

Implement the method that returns the sum of an arithmetic sequence elements when the common difference is 3.

$$\sum_{i=1}^{n} a+(i-1)*3=\sum_{i=0}^{n-1} a+i*3$$

Introduce a constant to avoid magic numbers in your code.

#### Sub-task 4

Implement the method that returns the sum of an arithmetic sequence elements.


### Quadratic Sequences

A *quadratic sequence* is an ordered set of terms that follows a rule based on the sequence $n^2=1, 4, 9, 16, 25,$ ...

The quadratic sequence formula is:
```math
a_{n} = a*n^2+b*n+c 
```
where
* $a_{n}$ is the nth term, and
* $a$, $b$ and $c$ are constants.

#### Sub-task 5

Open the [QuadraticSequences.cs](WhileStatements/QuadraticSequences.cs) file.

Implement the method that returns sum of a quadratic sequence terms that are less than _maxTerm_.

The quadratic sequence with nth term  
```math
a_{n}=3*n^2+5*n+7
``` 
is $\{ 15, 29, 49, 75, 107, 145, ...\}$

If _maxTerm_ is 29, the sum is 44 (15 + 29 = 44). If _maxTerm_ is 107, the sum is 275 (15 + 29 + 49 + 75 + 107 = 275).

The algorithm you have to implement is shown on the flowchart diagram below.

![Quadratic Sequence 1 Diagram](images/qs-1.png)

#### Sub-task 6

Implement the method that returns the sum of _count_ quadratic sequence terms starting with the _startN_ term.

For the quadratic sequence $\{ 15, 29, 49, 75, ...\}$ the sum is 44 (15 + 29 = 44), if the _startN_ is 1 and _count_ is 2. If _startN_ is 2 and _count_ is 3, the sum is 153 (29 + 49 + 75 = 153).


### Geometric Sequences

A *geometric sequence* is a sequence of terms in which the ratio between consecutive terms is constant.

The geometric sequence formula is given as,

$a_{n} = a*r^n$

where,
* $a_{n}$ is the nth term,
* $a$ is the first term, and
* r is the common ratio

#### Sub-task 7

Open the [GeometricSequences.cs](WhileStatements/GeometricSequences.cs) file.

Implement the method that returns the sum of a geometric sequence terms.

$$\sum_{i=1}^{n}a*r^{i-1}=\sum_{i=0}^{n-1}a*r^{i}=a+a*r^1+a*r^2+a*r^3+...+a*r^{n-1}$$

Use an additional _while_ statement to raise an _r_ number to the power of _n_.

The algorithm you have to implement is shown on the flowchart diagram below.

![Geometric Sequence 1 Diagram](images/gs-1.png)
