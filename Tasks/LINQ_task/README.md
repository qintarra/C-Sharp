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

### Task 9

A sequence of non-empty strings **stringList** is given, containing only uppercase letters of the
Latin alphabet.
For all strings starting with the same letter, determine their total length and obtain a sequence
of strings of the form "S-C", where **S** is the total length of all strings from stringList that begin
with the character **C**. Order the resulting sequence in descending order of the numerical values
of the sums, and for equal values of the sums, in ascending order of the **C** character codes.

### Task 10

A sequence of non-empty strings of Latin alphabet characters **stringList** is given.
Among all strings of the same length, sorted in ascending order, select the last character from
each string, converting it to uppercase, and from the received characters, compose a string.
Arrange the resulting sequence of strings in descending order of their lengths.

## Part Advanced

At the Advanced level, you need to solve the following five tasks:

### Task 11

A sequence of data about applicants _nameList_ of type _Entrant_ is given. Each element of the
sequence includes the fields _School number_, _Year of entering_, _Last name_.
Get data (list of _YearSchoolStat_ values) about the number of different schools that applicants
graduated from for each year present in the source data. The _YearSchoolStat_ type includes the
_Year of entering_, _Number of Schools_ fields. The list of _YearSchoolStat_ values must be
sorted in ascending order of the number of schools, and for matching values, in ascending order
of the year number.  

### Task 12

A sequence of positive integers integerList1 and integerList2 are given. All values in each
sequence are different.
Get a set (list of NumberPair values) of all value pairs that satisfy the following conditions:
the first element of the pair belongs to the sequence integerList1, the second belongs to
integerList2, and both elements end with the same digit. The NumberPair type includes
Value 1, Value 2 fields. The resulting NumberPair list must be sorted in ascending order
by the first field, and if they are equal, by the second.

### Task 13

A sequence of data about applicants _nameList_ of type _Entrant_ and a sequence of integers
_yearList_ representing years are given. Each element of the nameList sequence includes the
fields _School number_, _Year of entering_, _Last name_.
Get data (a list of _YearSchoolStat_ values) about the number of different schools that applicants
graduated from, for each year from the _yearList_. _YearSchoolStat_ includes _Year of entering_,
_Number of Schools_ fields. If in the given year of admission there are no applicants from the
listed schools, indicate zero in the field _Number of schools_. The _YearSchoolStat_ list must be
sorted in ascending order by the number of schools, and for matching values, in ascending
order by the year number.  

### Task 14

A sequence of customer information for a supplierList of type Supplier and a sequence of
discounts for customers in various stores, supplierDiscountList of type SupplierDiscount is
given. Each element of the supplierList sequence includes the fields Customer ID, Year
of birth, Street of residence. Each element of the supplierDiscountList sequence includes
the fields Customer ID, Store Name, Discount (Percentage).
Get a list (MaxDiscountOwner values) of all stores and for each store find a customer who has
the maximum discount in it. If for a certain store there are several customers with the maximum
discount, then take the data on the consumer with the minimum code. Sort the list by store
names in ascending alphabetical order.  

### Task 15
A sequence of information about goods goodList of type Good and a sequence of prices of
goods in various stores storePriceList of type StorePrice are given. Each element of the
goodList sequence includes the Product SKU, Category, Country of origin fields.
Each element of the storePriceList sequence includes the Product SKU, Store Title,
Price fields.
For each country of origin get the number of stores offering goods manufactured in that
country, as well as the minimum price for goods from this country for all stores (CountryStat
values). If no product is found for a certain country that is presented in any store, then the
number of stores and the minimum price are assumed to be 0. Sort the list by country of origin.  

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
