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
