using System;
using System.Collections.Generic;
using System.Threading;

// Exceeding Requirements:
// Adds ActivityLog class to track how many times each activity was performed during the session.
// User can select option 4 to view the activity log.

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        ActivityLog log = new ActivityLog();

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. View Activity Log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    log.Increment("Breathing");
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    log.Increment("Reflection");
                    break;
                case "3":
                    activity = new ListingActivity();
                    log.Increment("Listing");
                    break;
                case "4":
                    log.Display();
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }

            if (activity != null)
            {
                activity.Run();
            }
        }
    }
}
