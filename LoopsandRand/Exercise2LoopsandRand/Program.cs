/* Write a program and continuously ask the user to enter a number or "ok" to exit.
 Calculate the sum of all the previously entered numbers and display it on the console.*/

var total = 0;

while(true)
{
    Console.WriteLine("Please enter a number or ok: ");
    var response = Console.ReadLine();
    if (response == "OK")
        break;
    var number = int.Parse(response);
    total += number;
}
Console.WriteLine($"The total is: {total}");