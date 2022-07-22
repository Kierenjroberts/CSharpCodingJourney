/* Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
   Display the count on the console.*/

for (var x = 0; x <= 100; x++)
{
    if (x % 3 == 0)
        Console.WriteLine($"{x}");
}