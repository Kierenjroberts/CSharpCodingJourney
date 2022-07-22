/* Write a program and ask the user to enter a number.
 Compute the factorial of the number and print it on the console. 
For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/


Console.WriteLine("Please enter a number you would like to factorial: ");
var number = int.Parse(Console.ReadLine());

var total = number;
for (var i = number-1; i > 1; i--)
{
    total *= i;
}

Console.WriteLine($"{total}");