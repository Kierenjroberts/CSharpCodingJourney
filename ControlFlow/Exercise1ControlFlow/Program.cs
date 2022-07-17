var number = 0;

Console.WriteLine("Please enter a number between 1-10:\n ");
number = Int32.Parse(Console.ReadLine());

if (number >=1 && number <=10)
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Invalid");
}