using System;

class clockTask
{
    static void Main(string[] args)
    {
        // Declaring decimal variables, taking input
        decimal angle, hours, minutes;

        Console.WriteLine("Input hours: ");
        hours = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Input minutes: ");
        minutes = decimal.Parse(Console.ReadLine());

        // The minute arrow turns by 6 degrees each minute, the hour arrow by 0.5 degrees each minute and 30 degrees every hour.
        // I used the remainder operator to turn 24 hour format input to 12 hour format.
        angle = (minutes * 6) - ((hours % 12) * 30 + minutes * 0.5m);
        if (angle > 180) angle = 360 - angle;
        Console.WriteLine("Answer: " + Math.Abs(angle) + " degrees.");
    }
}