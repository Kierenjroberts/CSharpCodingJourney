/*
 * Your job is to write a program for a speed camera.
 * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
 * Write a program that asks the user to enter the speed limit.
 * Once set, the program asks for the speed of a car.
 * If the user enters a value less than the speed limit, program should display Ok on the console.
 * If the value is above the speed limit, the program should calculate the number of demerit points.
 * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
 * If the number of demerit points is above 12, the program should display License Suspended.
 */

var speedLimit = 0;
var speed = 0;

Console.WriteLine("What is the speed limit? \n");
speedLimit = Int32.Parse(Console.ReadLine());

Console.WriteLine("What speed were you going? \n");
speed = Int32.Parse(Console.ReadLine());

if (speedLimit > speed)
{
    Console.WriteLine("OK");
}
else
{
    var demeritPoints = (speed - speedLimit) / 5;
    Console.WriteLine("Your demerit points amount: {0}", demeritPoints);
    if (demeritPoints > 12)
    {
        Console.WriteLine("License Suspended");
    }
}