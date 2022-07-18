/* Write a program and ask the user to enter their name.
 Use an array to reverse the name and then store the result in a new string. 
Display the reversed name on the console.
*/

var name = "";
Console.WriteLine("Please enter a name: ");
name = Console.ReadLine();

char[] letters = name.ToCharArray();
Array.Reverse(letters);

Console.WriteLine(letters);