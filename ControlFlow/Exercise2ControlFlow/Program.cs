using System.ComponentModel.Design;

var number1 = 0;
var number2 = 0;

Console.WriteLine("Please enter your first number: \n");
number1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Please enter your second number: \n");
number2 = Int32.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("The highest number is: {0}", number1);
}
else
{
    Console.WriteLine("The highest number is: {0}", number2);
}