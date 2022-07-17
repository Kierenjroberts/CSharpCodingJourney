
Console.WriteLine("Please enter a number you would like to factorial: ");
var number = Int32.Parse(Console.ReadLine());

var total = number;
for (var i = number-1; i > 1; i--)
{
    total *= i;
}

Console.WriteLine($"{total}");