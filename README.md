# FizzBuzz
## Over engineered FizzBuzz

This is a C# .NET Core console application that prints out the numbers 1 - 100.  If the number is a multiple of three, it prints out "Fizz", a multiple of five prints out "Buzz", a multiple of seven prints out "Wizz", and a multiple of eleven prints out "Bang."  The number fifteen would print out "FizzBuzz", the number 33 would print out "FizzBang", and the number 70 would print out "BuzzWizz", etc.

## Blazor
There is a Blazor project in this solution to provide a web application GUI for getting output.  This is not yet complete.

## Plans for improvement
The Blazor implementation needs to have the start and end values as input in the setup so the user can set the values.  I also want to add the ability to add as many multiple/string value replacemnts as they want.

Another potential improvement is to allow the user to input the start and stop numbers as well as the multiples and string replacements as parameters for the console application.
