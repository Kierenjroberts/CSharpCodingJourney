/* Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
 A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time".
 If the user doesn't provide any values, consider it as invalid time. */

Console.WriteLine("Please enter a time in the 24hr format: ");

var input = Console.ReadLine();

if (String.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("This is an invalid time.");
    return;
}

var components = input.Split(":");
if (components.Length != 2)
{
    Console.WriteLine("This is an invalid time.");
    return;
}

var hours = Convert.ToInt32(components[0]);
var minutes = Convert.ToInt32(components[1]);

if (hours >= 0 && hours <=23 && minutes >= 0 && minutes <= 59)
{
    Console.WriteLine("Ok");
}
else
{
    Console.WriteLine("This is an invalid time.");
}