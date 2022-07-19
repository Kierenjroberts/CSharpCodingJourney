/* Write a program and ask the user to enter a few numbers separated by a hyphen.
 If the user simply presses Enter, without supplying an input, exit immediately. 
Otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. */

Console.WriteLine("Please enter a set of numbers separated by a hyphen: ");

var numberStringHyphen = Console.ReadLine();
if (String.IsNullOrWhiteSpace(numberStringHyphen))
{
    return;
}

var numberString = numberStringHyphen.Split('-');
var numbersList = new List<int>();

foreach (var number in numberString)
{
    numbersList.Add(Convert.ToInt32(number));
}

numbersList.Sort();

var duplicates = false;
for (int i = 1; i < numbersList.Count; i++)
{
    if (numbersList[i] == numbersList[i - 1])
    {
        duplicates = true;
        break;
    }
}

var output = duplicates ? "Duplicates" : "No duplicates";
Console.WriteLine(output);