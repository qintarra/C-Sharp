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