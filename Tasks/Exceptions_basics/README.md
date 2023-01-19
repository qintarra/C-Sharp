# Exceptions basics


### ArgumentOutOfRangeException

#### Subtask 1-1

Open the *ThrowingArgumentOutOfRange.cs* file.

Add the code to test if an _i_ argument is in the allowable range, and throw an _ArgumentOutOfRangeException_ when the argument is outside the allowable range.


| i Interval    | Allowable Range | Exception                   |
|---------------|-----------------|-----------------------------|
| (-&infin;, -5]| No              | ArgumentOutOfRangeException |
| (-5, 5)       | Yes             |                             |
| [5, &infin;)  | No              | ArgumentOutOfRangeException |

1. Add an _if_ statement with empty code block.

```cs
public static bool CheckParameterAndThrowException1(int i)
{
    if (i <= -5 || i >= 5)
    {
    }

    return true;
}
```

2. Add the [throw expression](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw) to throw an _ArgumentOutOfRangeException_ object.

```cs
public static bool CheckParameterAndThrowException1(int i)
{
    if (i <= -5 || i >= 5)
    {
        throw new ArgumentOutOfRangeException();
    }

    return true;
}
```

3. Open the [ArgumentOutOfRangeException Constructors](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.-ctor) documentation page, and find a constructor with one string parameter.

```cs
public ArgumentOutOfRangeException (string? paramName);
```

The constructor description says:

_Initializes a new instance of the ArgumentOutOfRangeException class with the **name of the parameter** that causes this exception._

Add the name of the _i_ parameter as a string to the constructor call.

```cs
public static bool CheckParameterAndThrowException1(int i)
{-
    if (i <= -5 || i >= 5)
    {
        throw new ArgumentOutOfRangeException("i");
    }

    return true;
}
```

4. Replace the string constructor parameter with the [nameof expression](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof).

```cs
public static bool CheckParameterAndThrowException1(int i)
{
    if (i <= -5 || i >= 5)
    {
        throw new ArgumentOutOfRangeException(nameof(i));
    }

    return true;
}
```

#### Subtask 1-2

Add the code to test if an _l_ argument is in the allowable range, and throw an _ArgumentOutOfRangeException_ when the argument is outside the allowable range.

| l Interval    | Allowable Range | Exception                   |
|---------------|-----------------|-----------------------------|
| (-&infin; 0)  | No              |                             |
| [0, 7]        | Yes             |                             |
| (7, &infin;)  | No              | ArgumentOutOfRangeException |

There is no need to test if an _l_ argument is less than zero because _l_ is of unsigned data type.  

#### Subtask 1-3

Add the code to test if both _i_ and _d_ arguments are in the allowable ranges, and throw the _ArgumentOutOfRangeException_ when any of the method arguments are outside the allowable range.

| Parameter | Interval        | Allowable Range | Exception                   | Error Message                        |
|-----------|-----------------|-----------------|-----------------------------|--------------------------------------|
| i         | (-&infin; 0)    | No              |                             |                                      |
| i         | [0, 5)          | Yes             |                             |                                      |
| i         | [5, &infin;)    | No              | ArgumentOutOfRangeException | i should be in [0, 5) interval.      |
| d         | (-&infin; -1.0) | No              | ArgumentOutOfRangeException | d should be in [-1.0, 1.0] interval. |
| d         | [-1.0, 1.0]     | Yes             |                             |                                      |
| d         | (1.0, &infin;)  | No              | ArgumentOutOfRangeException | d should be in [-1.0, 1.0] interval. |

Open the [ArgumentOutOfRangeException Constructors](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.-ctor) documentation page, and find a constructor with two string parameters.

```cs
public ArgumentOutOfRangeException (string? paramName, string? message);
```

The constructor description says:

_Initializes a new instance of the ArgumentOutOfRangeException class with the name of the parameter that causes this exception and a **specified error message**._

Add error messages to the constructor calls:

```cs
throw new ArgumentOutOfRangeException(nameof(i), "i should be in [0, 5) interval.");

throw new ArgumentOutOfRangeException(nameof(d), "d should be in [-1.0, 1.0] interval.");
```

#### Subtask 1-4

Add the code to test if both _l_ and _f_ arguments are in the allowable ranges, and throw the _ArgumentOutOfRangeException_ when any of the method arguments are outside the allowable range.

| Parameter | Interval        | Allowable Range | Exception                   | Error Message                                |
|-----------|-----------------|-----------------|-----------------------------|----------------------------------------------|
| l         | (-&infin; -9)   | No              | ArgumentOutOfRangeException | l should be in [-9, -3) or [3, 9) intervals. |
| l         | [-9, -3)        | Yes             |                             |                                              |
| l         | [-3, 3)         | No              | ArgumentOutOfRangeException | l should be in [-9, -3) or [3, 9) intervals. |
| l         | [3, 9)          | Yes             |                             |                                              |
| l         | [9, &infin;)    | No              | ArgumentOutOfRangeException | l should be in [-9, -3) or [3, 9) intervals. |
| f         | (-&infin; -0.3] | No              | ArgumentOutOfRangeException | f should be in the (-0.3, 0.3) interval.     |
| f         | (-0.3, 0.3)     | Yes             |                             |                                              |
| f         | [0.3, &infin;)  | No              | ArgumentOutOfRangeException | f should be in the (-0.3, 0.3) interval.     |


### ArgumentNullException

#### Subtask 2-1

Add the _if_ statement to test if an _o_ argument is _null_, and throw the _ArgumentNullException_ when the argument is null.

```cs
public static bool CheckParameterAndThrowException1(object o)
{
    if (o == null)
    {
        throw new ArgumentNullException(nameof(o));
    }

    return true;
}
```

Beginning with C# 7.0, you can use a [constant pattern](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#constant-pattern) to check for _null_.

```cs
public static bool CheckParameterAndThrowException1(object o)
{
    if (o is null)
    {
        throw new ArgumentNullException(nameof(o));
    }

    return true;
}

#### Subtask 2-2

Open the *ThrowingArgumentNull.cs* file.

Add the _if_ statement to test if _o1_ or _o2_ arguments are _null_, and throw the _ArgumentNullException_ when any of the method arguments is null.

The _ArgumentNullException_ class has a [constructor with two string parameters](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception.-ctor?view=net-6.0#system-argumentnullexception-ctor(system-string-system-string)) that allows to specify an error message:

```cs
public ArgumentNullException (string? paramName, string? message);
```
