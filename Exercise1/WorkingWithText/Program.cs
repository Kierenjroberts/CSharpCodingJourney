/* Write a program and ask the user to enter a few numbers separated by a hyphen.
 Work out if the numbers are consecutive.
 For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive". */



Console.WriteLine("Please enter a set of numbers separated by a hyphen: ");

var numberStringHyphen = Console.ReadLine();
var numberString = numberStringHyphen.Split('-');
var numbersList = new List<int>();
var consecutive = true;

foreach (var number in numberString)
{
    numbersList.Add(Convert.ToInt32(number));
}

numbersList.Sort();

for (var i = 1; i < numbersList.Count; i++)
{
    if (numbersList[i] != numbersList[i - 1] + 1)
    {
        consecutive = false;
        break;
    }
}

if (consecutive == true)
{
    Console.WriteLine("Is consecutive.");
}
else
{
    Console.WriteLine("Is not consecutive.");
}

foreach (var i in numbersList)
{
    Console.WriteLine(i);
}