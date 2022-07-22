// Write a program that reads a text file and displays the number of words.

const string path = @"E:\Documents\ExerciseText.txt";

var textFromFile = File.ReadAllText(path);
Console.WriteLine(textFromFile);

var wordCount = textFromFile.Split(' ');
Console.WriteLine(wordCount.Length);