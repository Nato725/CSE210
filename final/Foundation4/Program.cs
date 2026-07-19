using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Running runActivity = new Running("01 Aug 2026", 10, 1.0);
        Cycling bikeActivity = new Cycling("02 Aug 2026", 15, 15.0);
        Swimming swimActivity = new Swimming("03 Aug 2026", 10, 5);

        List<Activity> activitiesList = new List<Activity>
        {
            runActivity,
            bikeActivity,
            swimActivity,
        };

    Console.WriteLine("EOS Fitness Activity Log:");

    foreach (Activity activity in activitiesList)
    {
        Console.WriteLine(activity.GetSummary());
    }
    }
}
