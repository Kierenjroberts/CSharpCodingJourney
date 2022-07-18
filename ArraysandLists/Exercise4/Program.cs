/* Write a program and ask the user to continuously enter a number or type "Quit" to exit.
 The list of numbers may include duplicates. 
Display the unique numbers that the user has entered. */

var numbers = new List <int>();

while (true)
{
    Console.WriteLine("Please enter a number or type Quit: ");
    var input = Console.ReadLine();

    if (input.ToLower() == "quit")
    {
        break;
    }

    numbers.Add(Convert.ToInt32(input));
}

var uniqueEntries = new List<int>();
foreach (var number in numbers)
{
    if (!uniqueEntries.Contains(number))
    {
        uniqueEntries.Add(number);
    }
}

Console.WriteLine("Unique numbers:");
foreach (var number in uniqueEntries)
    Console.WriteLine(number);