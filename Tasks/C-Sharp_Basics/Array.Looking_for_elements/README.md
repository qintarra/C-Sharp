# Looking for an Array Element

Intermediate level task for practicing loops, branches and arrays.

The task is to implement six methods using "for", "foreach", "while" and "do" statements.


## Task Description

You are allowed to use loop statements (for, while and do), [Array.Length](https://docs.microsoft.com/en-us/dotnet/api/system.array.length) and [Array.IList.Item[Int32]](https://docs.microsoft.com/en-us/dotnet/api/system.array.system-collections-ilist-item) properties only. You are not allowed to use other static or instance methods of the [Array class](https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1) or any extension method from [System.Linq namespace](https://docs.microsoft.com/en-us/dotnet/api/system.linq). You can create your private [static methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members) or [local functions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions).  

1. Implement "GetIntegersCount(int[], int[])" method in the [IntegersCounter.cs](LookingForArrayElements/IntegersCounter.cs) file. The method should count all elements of "arrayToSearch" array that appears in "elementsToSearchFor" array.  

Here's an example for ["GetIntegersCount_ParametersAreValid_ReturnsResult"](LookingForArrayElements.Tests/IntegersCounterTests.cs#L55) unit test.  

arrayToSearch is an array with { 1, 2, 3, 4, 5, 6, 7, 8, 9 } elements, and elementsToSearchFor is an array with { 2, 5, 8 } elements.  

| Position in arrayToSearch  | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 |
|----------------------------|---|---|---|---|---|---|---|---|---|
| arrayToSearch values       | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
| elementsToSearchFor values |   | 2 |   |   | 5 |   |   | 8 |   |
| Sum = 3                    | 0 | 1 | 0 | 0 | 1 | 0 | 0 | 1 | 0 |

2. Implement "GetIntegersCount(int[], int[], int, int)" method in the [IntegersCounter.cs](LookingForArrayElements/IntegersCounter.cs) file. The method should work like the previous one, but it has additional options (startIndex and count) that can be used for getting a subset of arrayToSearch.  

Here's an example for ["GetIntegersCount_ParametersAreValid_ReturnsResult"](LookingForArrayElements.Tests/IntegersCounterTests.cs#L136) unit test.  

arrayToSearch is an array with { 1, 2, 3, 4, 5, 6, 7, 8, 9 } elements, and elementsToSearchFor is an array with { 2, 5, 8 } elements. startIndex is 2, and count is 5.  
