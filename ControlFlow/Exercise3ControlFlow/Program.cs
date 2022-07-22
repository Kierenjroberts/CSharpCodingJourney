/* Write a program and ask the user to enter the width and height of an image.
 Then tell if the image is landscape or portrait.*/

var width = 0;
var height = 0;

Console.WriteLine("What is the width of your image? \n");
width = Int32.Parse(Console.ReadLine());
Console.WriteLine("What is the height of your image? \n");
height = Int32.Parse(Console.ReadLine());

if (height > width)
{
    Console.WriteLine("Your image is portrait.");
}
else if (width > height)
{
    Console.WriteLine("Your image is landscape.");
}
else
{
    Console.WriteLine("Your image is a Square.");
}