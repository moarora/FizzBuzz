# FizzBuzz

### Summary
A C# implemntation of FizzBuzz that provides functionality to enumerate through a range of values and test for divisibility.

### Requirements
.NET Framework v4.5

NUnit v2.6.4

### Build
Use Visual Studio 2012

### Details
#####FizzBuzzLib
Takes a range and enumerates over that range checking each value and returning a string based on the following logic.
- Return "Fizz" if the number is divisible by 3.
- Return "Buzz" if the number is divisible by 5.
- Return "FizzBuzz" if the number is divisible by both 3 and 5,
- Return the value if it is not divisible by 3 nor 5.

Values are returned through an IEnumerable interface.

#####FizzBuzzLib.Tests
A library containing unit test coverage for FizzBuzzLib. Leveraging the NUnit Framework which will be pulled down via NuGet.

#####FizzBuzzConsole
A very simple console application that calls FizzBuzzLib for a range of 1-100 and outputs the results.
