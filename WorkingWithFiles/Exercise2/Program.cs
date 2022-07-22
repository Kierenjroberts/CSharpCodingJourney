// Write a program that reads a text file and displays the longest word in the file.


const string path = @"E:\Documents\ExerciseText.txt";

var textFromFile = File.ReadAllText(path);
Console.WriteLine(textFromFile);

var wordList = textFromFile.Split(' ');
var wordCount = 0;

foreach (var x in wordList)
{
    Console.WriteLine(x);
}



foreach (var word in wordList)
{
    if (wordCount < Convert.ToInt32(word.Length))
    {
        wordCount = word.Length;
    }
}

Console.WriteLine(wordCount);