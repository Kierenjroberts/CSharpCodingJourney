﻿/*
Write a program and ask the user to enter a series of numbers separated by comma. 
Find the maximum of the numbers and display it on the console. 
For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

*/

Console.WriteLine("Please enter a set of numbers separated by a comma: ");
var comparison = 0;
var numberChoice = Console.ReadLine();
var splitString = numberChoice.Split(",");
int[] numberList = new int[splitString.Length];

for (int i = 0; i < splitString.Length; i++)
{
    numberList[i] = int.Parse(splitString[i]);
}

foreach (var number in numberList)
{
    if (number > comparison)
    {
        comparison = number;
    }
}

Console.WriteLine($"The biggest number in this list is {comparison}");



