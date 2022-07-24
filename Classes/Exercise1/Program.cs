/* Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
   provide two methods: Start and Stop. We call the start method first, and the stop method next.
   Then we ask the stopwatch about the duration between start and stop. Duration should be a
   value in TimeSpan. Display the duration on the console.
   We should also be able to use a stopwatch multiple times. So we may start and stop it and then
   start and stop it again. Make sure the duration value each time is calculated properly.
   We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
   start time). So the class should throw an InvalidOperationException if its started twice. */


using System.Diagnostics;
using Exercise1;

var stopwatch = new StopWatch();
var continueStopWatch = true;

do
{
    Console.WriteLine("Press enter to start the stopwatch, enter any key to terminate");
    stopwatch.beginningWatch = Console.ReadLine();

    if (!String.IsNullOrWhiteSpace(stopwatch.beginningWatch))
    {
        continueStopWatch = false;
        break;
    }

    var startTime = stopwatch.Start();

    Console.WriteLine("Press enter to stop the stopwatch, enter any key to terminate");
    stopwatch.endingWatch = Console.ReadLine();
    if (!String.IsNullOrWhiteSpace(stopwatch.endingWatch))
    {
        continueStopWatch = false;
        break;
    }

    var timeElapsed = stopwatch.StopAndCalculateDuration(startTime);

    Console.WriteLine(timeElapsed);

} while (continueStopWatch);


