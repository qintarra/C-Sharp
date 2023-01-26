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
```

#### Subtask 2-2

Open the *ThrowingArgumentNull.cs* file.

Add the _if_ statement to test if _o1_ or _o2_ arguments are _null_, and throw the _ArgumentNullException_ when any of the method arguments is null.

The _ArgumentNullException_ class has a [constructor with two string parameters](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception.-ctor?view=net-6.0#system-argumentnullexception-ctor(system-string-system-string)) that allows to specify an error message:

```cs
public ArgumentNullException (string? paramName, string? message);
```

Usually having an error message is not needed for an _ArgumentNullException_, because the issue is described by the exception type. In this task you don't have to specify an error message for an _ArgumentNullException_.

#### Subtask 2-3

Add the code to test if the method argument (_integers_, _longs_ and _floats_) is _null_, and throw an _ArgumentNullException_ when any of the method arguments is null.  

#### Subtask 2-4

Add the code to test if a string argument is null, and throw the _ArugmentNullException_ when the argument is null.

```cs
public static int CheckParameterAndThrowException4(string s)
{
    if (s is null)
    {
        throw new ArgumentNullException(nameof(s));
    }

    return s.Length;
}
```

#### Subtask 2-5

Add the code to throw the _ArgumentNullException_ when any of the method arguments are null.

#### Subtask 2-6

Add the code to throw the _ArgumentNullException_ when any of the method arguments are null.

### The Null-coalescing Operator ??

#### Subtask 2-7

Add the code to throw the _ArgumentNullException_ when an _integers_ argument is null.  

1. Add the parenthesis around the _integer_ parameter.

```cs
public static int CheckParameterAndThrowException7(int[] integers)
{
    int integersCount;

    integersCount = (integers).Length;

    return integersCount;
}
```

2. Add the null-coalescing operator to throw the _ArgumentNullException_ when an _integers_ argument is null.

```cs
public static int CheckParameterAndThrowException7(int[] integers)
{
    int integersCount;

    integersCount = (integers ?? throw new ArgumentNullException()).Length;

    return integersCount;
}
```

3. Use the _nameof_ expression to specify the _integers_ parameter name.

```cs
public static int CheckParameterAndThrowException7(int[] integers)
{
    int integersCount;

    integersCount = (integers ?? throw new ArgumentNullException(nameof(integers))).Length;

    return integersCount;
}
```

#### Subtask 2-8

Add the code to throw the _ArgumentNullException_ when any of the method arguments are null.  

#### Subtask 2-9

Add the code to throw the _ArgumentNullException_ when any of the method arguments are null.


### The Null-coalescing Assignment Operator ??=  

#### Subtask 3-1

Open the *NullCoalescingAssignment.cs* file.

Add the code to initialize the _o_ parameter with the default value when the _o_ argument is null.

| Parameter | Default Value |
|-----------|---------------|
| o         | new object()  |

Use the [null-coalescing assignment operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator):

```cs
public static object CheckParameterAndThrowException7(object o)
{
    o ??= new object();

    return o;
}
```

#### Subtask 3-2

Add the code to initialize the _integers_ parameter with the default value when the _integers_ argument is null.

| Parameter | Default Value   |
|-----------|-----------------|
| integers  | new int[] { 0 } |

#### Subtask 3-3

Add the code to initialize the _s_ parameter with the default value when the _s_ argument is null.

| Parameter | Default Value   |
|-----------|-----------------|
| s         | "Hello, world!" |

The string parameters are initialized in the same way as the object and the array parameters:

```cs
public static string CheckParameterAndThrowException3(string s)
{
    s ??= "Hello, world!";

    return s;
}
```

#### Subtask 3-4

Add the code to initialize the _s1_ and _s2_ parameters with the default values when the _s1_ or _s2_ argument is null.

| Parameter | Default Value   |
|-----------|-----------------|
| s1        | "Hello"         |
| s2        | "world"         |

#### Subtask 3-5

Add the code to initialize the method parameters with the default values when any argument is null.

| Parameter | Default Value         |
|-----------|-----------------------|
| s1        | "abc"                 |
| integers  | new int[] { 1, 2, 3 } |
| s2        | "123"                 |


### ArgumentException

#### Subtask 4-1

Open the ThrowingArgument.cs file.

Add the code block to throw the _ArgumentException_ when the _i_ argument is odd. The exception's error message should be "i should not be odd.".

1. Add the _if_ statement that tests if an _i_ is odd.

```cs
public static int CheckParameterAndThrowException1(int i)
{
    if (i % 2 != 0)
    {
    }

    return i;
}
```

2. Add the _throw_ expression to throw the _ArgumentOutOfRangeException_.

```cs
public static int CheckParameterAndThrowException1(int i)
{
    if (i % 2 != 0)
    {
        throw new ArgumentException();
    }

    return i;
}
```

3. Specify the error message.

```cs
public static int CheckParameterAndThrowException1(int i)
{
    if (i % 2 != 0)
    {
        throw new ArgumentException("i should not be odd.");
    }

    return i;
}
```

4. Use the _nameof_ expression to specify the _i_ parameter name.

```cs
public static int CheckParameterAndThrowException1(int i)
{
    if (i % 2 != 0)
    {
        throw new ArgumentException("i should not be odd.", nameof(i));
    }

    return i;
}
```

Pay attention that the error message parameter goes first in the [ArgumentException constructors](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception.-ctor).

```cs
public ArgumentException(string? message, string? paramName);
```

#### Subtask 4-2

Add the code to throw the _ArgumentException_ when _s_ argument equals zero. The error message should be "s should not equals zero.".  

#### Subtask 4-3

Add the code to throw the _ArgumentException_ when _l_ argument is even. The error message should be "l should not be even.".

#### Subtask 4-4

Add the code to throw the _ArgumentException_ when the _floats_ array has no elements. The error message should be "floats array has no elements.".

1. Add an _if_ statement that tests if the _floats_ array is empty.

```cs
public static int CheckParameterAndThrowException4(float[] floats)
{
    if (floats.Length == 0)
    {
    }

    return floats.Length;
}
```

2. Add an _throw_ expression to throw the _ArgumentException_ when the _floats_ array is empty. Specify the error message and the parameter name in the exception constructor.

```cs
public static int CheckParameterAndThrowException4(float[] floats)
{
    if (floats.Length == 0)
    {
        throw new ArgumentException("floats array has no elements.", nameof(floats));
    }

    return floats.Length;
}
```

3. In such cases it makes sense to add an additional check for testing an argument for _null_. Add an _if_ statement that throws the _ArgumentNullException_ when the _floats_ argument is _null_.

```cs
public static int CheckParameterAndThrowException4(float[] floats)
{
    if (floats is null)
    {
        throw new ArgumentNullException(nameof(floats));
    }

    if (floats.Length == 0)
    {
        throw new ArgumentException("floats array has no elements.", nameof(floats));
    }

    return floats.Length;
}
```

#### Subtask 4-5

Add the code to throw the _ArgumentException_ when the _s_ string is empty. The error message should be "s string is empty.". Also, add the code to throw an _ArgumentNullException_ when _s_ argument is _null_.  


