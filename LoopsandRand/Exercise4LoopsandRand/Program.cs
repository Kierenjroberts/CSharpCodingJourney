/* Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
 If the user guesses the number, display “You won"; otherwise, display “You lost". 
(To make sure the program is behaving correctly, you can display the secret number on the console first.)*/

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

Console.WriteLine(lives == 0 ? "You ran out of lives" : "Congratulations");

