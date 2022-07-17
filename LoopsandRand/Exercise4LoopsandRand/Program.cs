var rand = new Random();
var number = rand.Next(1, 10);
var lives = 4;

while (lives > 0)
{
    Console.WriteLine("Please guess a number between 1 - 10: ");
    var playerChoice = Int32.Parse(Console.ReadLine());
        if (playerChoice == number)
    {
        Console.WriteLine("You have guessed correctly!");
        Console.WriteLine($"You had {lives} lives remaining.");
        break;
        
    }
        else 
        {
            lives -= 1;
            Console.WriteLine($"You have {lives} lives remaining.");
        }
}

if (lives == 0)
{
    Console.WriteLine("You ran out of lives");
}
else
{
    Console.WriteLine("Congratulations");
}

