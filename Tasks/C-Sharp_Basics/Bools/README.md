# Bools and Logic Operators

### Bools

Open the *Booleans.cs* file, and implement all methods by returning a Boolean value.

| Method Name | Literals |
|-------------|----------|
| ReturnTrue  | true     |
| ReturnFalse | false    |

There are only two possible literals for the _bool_ data type - _true_ and _false_.

### Logical Operators

Open the *LogicalOperators.cs* file, and implement all methods by applying a logical operator to method parameters.

| Method Name | Logical Operation    | Operator |
|-------------|----------------------|----------|
| LogicalAnd1 | Logical AND          | &&       |
| LogicalAnd2 | Logical AND          | &&       |
| LogicalAnd3 | Logical AND          | &&       |
| LogicalOr1  | Logical OR           | \|\|     |
| LogicalOr2  | Logical OR           | \|\|     |
| LogicalOr3  | Logical OR           | \|\|     |
| LogicalXor1 | Logical exclusive OR | ^        |
| LogicalXor2 | Logical exclusive OR | ^        |
| LogicalXor3 | Logical exclusive OR | ^        |
| Negate      | Logical negation     | !        |


Create the [truth table](https://en.wikipedia.org/wiki/Truth_table) for _logical AND (conjunction)_ for the _b1_ and _b2_ parameters.

| b1    | b2    | b1 && b2 |
|-------|-------|----------|
| false | false | false    |
| true  | false | false    |
| false | true  | false    |
| true  | true  | true     |

Implement the other methods and create the truth tables for them.


### Logical Puzzles

In this section, you have to use the logical operators to solve the logical puzzles in the *LogicalPuzzles.cs* file. You can combine the logical operators together to get the expected result of a logical function. Start with creating a _truth table_ for a logical function you work with, then analyze it and reconstruct a logical function to satisfy the truth table criteria.  

Take a look at the list of test cases for the *Puzzle1_ReturnBool* unit test and create an expected truth table for the operation you have to implement in the _Puzzle1_ method.

| b1    | b2    | Expected Result |
|-------|-------|-----------------|
| false | false | true            |
| true  | false | false           |
| false | true  | true            |
| true  | true  | true            |

Compare this truth table with the [truth table for logical OR operation](https://en.wikipedia.org/wiki/Truth_table#Logical_disjunction_(OR)) - you will find that they are very similar.

| b1    | b2    | Logical OR      |
|-------|-------|-----------------|
| false | false | false           |
| true  | false | true            |
| false | true  | true            |
| true  | true  | true            |

Apply _operator ||_ to _b1_ and _b2_ parameters.

```cs
public static bool Puzzle1(bool b1, bool b2)
{
    return b1 || b2;
}
```

Now, the _Puzzle1_ truth table is similar to the expected truth table except for the case when the _b2_ parameter is false.

| b1    | b2    | Actual Result | Expected Result |
|-------|-------|---------------|-----------------|
| false | false | **false**     | **true**        |
| true  | false | **true**      | **false**       |
| false | true  | true          | true            |
| true  | true  | true          | true            |

That means a logical negation should be applied to the _b1_ parameter.

```cs
public static bool Puzzle1(bool b1, bool b2)
{
    return !b1 || b2;
}
```

Now the method produces correct expected results for all test cases for the _Puzzle1_ReturnBool_ unit test.

Implement the other logical puzzles in the same way. Some puzzles assume using parentheses to change the order of [operand evaluation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/#operand-evaluation).
