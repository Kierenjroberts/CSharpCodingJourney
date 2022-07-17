var number = 0;
var total = 0;

while(true)
{
    Console.WriteLine("Please enter a number or ok: ");
    var response = Console.ReadLine();
    if (response == "OK")
        break;
    number = Int32.Parse(response);
    total += number;
}
Console.WriteLine($"The total is: {total}");