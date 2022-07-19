/* Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
 If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
*/

string[] stringLength;

while (true)
{
    Console.WriteLine("Please provide a list of numbers separated by commas: ");
    var input = Console.ReadLine();

    if (!String.IsNullOrWhiteSpace(input))
    {
        stringLength = input.Split(',');
        if (stringLength.Length >= 5)
        {
            break;
        }

        Console.WriteLine("That is an invalid list. Try again.");
    }
}

var numbers = new List<int>();


foreach (var number in stringLength)
{
    numbers.Add(Convert.ToInt32(number));
}

var smallestList = new List<int>();

while (smallestList.Count < 3)
{
    var comparison = numbers[0];
    foreach (var number in numbers)
    {
        if (number < comparison)
        {
            comparison = number;
        }

    }
    smallestList.Add(comparison);
    numbers.Remove(comparison);
}

foreach (var number in smallestList)
{
    Console.WriteLine(number);
}
