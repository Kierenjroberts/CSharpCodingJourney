var path = @"E:\Documents\ExerciseText.txt";

var textFromFile = File.ReadAllText(path);
Console.WriteLine(textFromFile);

var wordCount = textFromFile.Split(' ');
Console.WriteLine(wordCount.Length);