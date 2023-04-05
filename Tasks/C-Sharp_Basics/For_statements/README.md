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

$$\sum_{i=1}^{n} a+(i-1)\cdot{1}=\sum_{i=0}^{n-1} a+i$$

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

2. Add the [for statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement) that iterates until _i_ is less than _n_. The `for` statement has three elements - _initializer_, _condition_ and _iterator_ sections.

```cs
public static int SumArithmeticSequenceTerms1(int a, int n)
{
    int sum = 0;

    for (int i = 0; i < n; i = i + 1)
    {
    }

    return sum;
}
```
![Arithmetic Sequence 2 Diagram](images/as-2.png)

3. Add the sum calculation.

```cs
public static int SumArithmeticSequenceTerms1(int a, int n)
{
    int sum = 0;

    for (int i = 0; i < n; i = i + 1)
    {
        sum = sum + a + i;
    }

    return sum;
}
```

4. Replace the assignment with addition assignment operator *+=*

```cs
public static int SumArithmeticSequenceTerms1(int a, int n)
{
    int sum = 0;

    for (int i = 0; i < n; i = i + 1)
    {
        sum += a + i;
    }

    return sum;
}
```

5. Replace the assignment with increment operator *++*

```cs
public static int SumArithmeticSequenceTerms1(int a1, int n)
{
    int sum = 0;

    for (int i = 0; i < n; i++)
    {
        sum += a + i;
    }

    return sum;
}
```

#### Task 2

Implement the method that returns the sum of an arithmetic sequence elements when the first term is 47 and the common difference is 13.

$$\sum_{i=1}^{n} 47+(i-1)\cdot{13}=\sum_{i=0}^{n-1} 47+i\cdot{13}$$

Beginner programmers often put number literals in their code like this:

```cs
public static int SumArithmeticSequenceTerms2(int n)
{
    int sum = 0;

    for (int i = 0; i < n; i++)
    {
        sum += 47 + (i * 13);
    }

    return sum;
}
```

Experienced programmers consider using number literals with unexplained meaning as a *bad practice*. They call such literals [magic numbers](https://en.wikipedia.org/wiki/Magic_number_(programming)).

If you have a magic number in your code, [replace it with a symbolic constant](https://refactoring.guru/replace-magic-number-with-symbolic-constant):

```cs
public static int SumArithmeticSequenceTerms2(int n)
{
    const int firstTerm = 47;
    const int commonDifference = 13;

    int sum = 0;

    for (int i = 0; i < n; i++)
    {
        sum += firstTerm + (i * commonDifference);
    }

    return sum;
}
```

#### Task 3

Implement the method that returns the sum of an arithmetic sequence elements when the common difference is 5.

$$\sum_{i=1}^{n} a+(i-1)\cdot{5}=\sum_{i=0}^{n-1} a+i\cdot{5}$$

Introduce a constant to avoid magic numbers in your code.


### Factorial

The *factorial* of a non-negative integer $n$, denoted by $n!$, is the product of all positive integers less than or equal to $n$.

$$n!=\prod_{i=1}^{n}i=1\cdot...\cdot(n-1)\cdot{n}$$

#### Task 4

Open the [Factorial.cs](ForStatements/Factorial.cs) file.

Implement the method that returns the factorial of the number $n!$ using the `for` statement.

#### Task 5

Implement the method that calculates the factorial of the number $n!$ and returns the sum of its digits using the `for` statement.

$10!=1\cdot{2}\cdot{3}\cdot{4}\cdot{5}\cdot{6}\cdot{7}\cdot{8}\cdot{9}\cdot{10}=3628800$

The sum of digits of 3,628,800 is 27 (3+6+2+8+8).

Use the remainder operator `%` to get the last digit of factorial of a number.

The expression in the condition section may use any variable, not only variables mentioned in the initializer or iterator sections.

```cs
for (int sum = 0; product > 0; product = product / 10)
{
    sum += product % 10;
}
```

Use the *compound assignment expression* instead of the division operator.

```cs
for (int sum = 0; product > 0; product /= 10)
{
    sum += product % 10;
}
```

You can leave any section empty if this makes sense for your algorithm:

```cs
int sum = 0;

for (; product > 0; product /= 10)
{
    sum += product % 10;
}

return sum;
```


### Quadratic Sequences

A *quadratic sequence* is an ordered set of terms that follows a rule based on the sequence $n^2=1, 4, 9, 16, 25,$ ...

The quadratic sequence formula is:

$a_{n} = a\cdot{n^2}+b\cdot{n}+c$

where,
* $a_{n}$ is the nth term, and
* $a$, $b$ and $c$ are constants.

#### Task 6

Open the [QuadraticSequences.cs](ForStatements/QuadraticSequences.cs) file.  

Implement the method that returns the number of the quadratic sequence terms that are less than or equals to the _maxTerm_.

The quadratic sequence with nth term $a_{n}=3\cdot{n^2}+5\cdot{n}+7$ is $\{ 15, 29, 49, 75, 107, 145, ...\}$.

If _maxTerm_ is 29, the number of terms is 2 (15 and 29 terms). If _maxTerm_ is 107, the number of terms is 5 (15, 29, 49, 75 and 107 terms).

The algorithm you have to implement is shown on the flowchart diagram below.

![Quadratic Sequence 1 Diagram](images/qs-1.png)

#### Task 7

Implement the method that returns the product of the first _count_ quadratic sequence terms.

The quadratic sequence with nth term $a_{n}=7\cdot{n^2}+4\cdot{n}+2$ is $\{ 13, 38, 77, 130, ...\}$.

If the _count_ is 2, the product is 494 (13 * 38 = 494). If the _count_ is 3, the product is 38038 (13 * 38 * 77 = 38038).

#### Task 8

Implement the method that returns the product of _count_ quadratic sequence terms starting with the _startN_ term.

For the quadratic sequence $\{ 15, 29, 49, 75, ...\}$ the product is 435 (15 * 29 = 435), if the _startN_ is 1 and _count_ is 2. If _startN_ is 2 and _count_ is 3, the product is 106575 (29 * 49 * 75 = 106575).


### Fibonacci Sequence

The *Fibonacci sequence* is the series of numbers:

$\{ 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ... \}$

The sequence rule is:

$x_{n}=x_{n-1}+x_{n-2}$

where,
* $x_{n}$ is term number "n",
* $x_{n-1}$ is the previous term (n-1),
* $x_{n-2}$ is the term before that (n-2).

#### Task 9

Open the [FibonacciSequence.cs](ForStatements/FibonacciSequence.cs) file.

Implement the method that returns the Fibonacci sequence number using the `for` statement.

#### Task 10  

Implement the method that returns the product of digits of the Fibonacci sequence number using the `for` statement. Use the remainder operator `%` to get the last digit of factorial of a number.

If $n$ is 10, the $n$-th Fibonacci sequence number is 55 and the product of the number digits is 25 (5 * 5).


### Geometric Sequences

A *geometric sequence* is a sequence of terms in which the ratio between consecutive terms is constant.

The geometric sequence formula is given as,

$a_{n} = a\cdot{r^n}$

where,
* $a_{n}$ is the nth term,
* $a$ is the first term, and
* $r$ is the common ratio

#### Task 11

Open the [GeometricSequences.cs](ForStatements/GeometricSequences.cs) file.

Implement the method that returns the product of geometric sequence terms.

$$\prod_{i=1}^{n}a\cdot{r^{i-1}}=\prod_{i=0}^{n-1}a\cdot{r^{i}}=(a\cdot{1})\cdot(a\cdot{r^1})\cdot(a\cdot{r^2})\cdot(a\cdot{r^3})\cdot...\cdot(a\cdot{r^{n-1}})$$

Use a nested `for` loop to raise an _r_ number to a power. The [.NET BCL](https://docs.microsoft.com/en-us/dotnet/standard/glossary) has a special [Math.Pow](https://docs.microsoft.com/en-us/dotnet/api/system.math.pow) method for raising a number to a power, but since you in this you practice loops use the `for` loop instead of the _Math.Pow_ method.

```cs
uint rpow = 1;
for (int j = 0; j < i; j++)
{
    rpow *= r;
}
```

The algorithm you have to implement is shown on the flowchart diagram below.

![Geometric Sequence 1 Diagram](images/gs-1.png)

#### Task 12  

Implement the method that returns the sum of a geometric sequence terms when the first term is 5 and the common ratio is 3.

$$\sum_{i=1}^{n}a\cdot{r^{i-1}}=\sum_{i=0}^{n-1} 5\cdot{3^{i}}=5+5\cdot{3^1}+5\cdot{3^2}+5\cdot{3^3}+...+5\cdot{3^{n-1}}$$

Introduce a constant to avoid magic numbers in your code.

#### Task 13  

Implement the method that counts terms in a geometric sequence that are less than or equal to the _maxTerm_.

If _a_ is 3 and _r_ is 2 the geometric sequence is $\{3, 6, 12, 24, 48, ...\}$. If _maxTerm_ is 3 the count equals to 1 ($\{3\}$). If  _maxTerm_ is 24 the count equals to 4 ($\{3, 6, 12, 24\}$).

The algorithm you have to implement is shown on the flowchart diagram below.
