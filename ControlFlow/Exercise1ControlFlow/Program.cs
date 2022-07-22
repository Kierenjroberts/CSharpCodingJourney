/* Write a program and ask the user to enter a number.
 The number should be between 1 to 10. 
 If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
 (This logic is used a lot in applications where values entered into input boxes need to be validated.)*/

var number = 0;

Console.WriteLine("Please enter a number between 1-10:\n ");
number = Int32.Parse(Console.ReadLine());

Console.WriteLine(number is >= 1 and <= 10 ? "Valid" : "Invalid");