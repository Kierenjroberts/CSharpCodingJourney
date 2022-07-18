/* When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern.
*/
var names = new List<string>();

while (true)
{
    Console.WriteLine("Press enter to exit or enter a name: ");
    var addName = Console.ReadLine();
    var namesCount = (names.Count() - 2);
    if (addName == "")
    {
        if (names.Count == 0)
        {
            Console.WriteLine("No one likes your post.");
        }
        else if (names.Count == 1)
        {
            Console.WriteLine($"{names[0]} liked your post.");
        }
        else if (names.Count == 2)
        {
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        }
        else
        {
            Console.WriteLine($"{names[0]}, {names[1]}, and {namesCount} others like your post.");
        }
        break;
    }
    names.Add(addName);
}