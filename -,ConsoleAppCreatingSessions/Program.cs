using System;
using System.Collections.Generic;

namespace ConsoleAppSession
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulate session data storage using a Dictionary
            Dictionary<string, object> session = new Dictionary<string, object>();

            // Store some session data
            session["UserId"] = 1;
            session["UserName"] = "JohnDoe";

            // Access session data
            Console.WriteLine("User ID: " + session["UserId"]);
            Console.WriteLine("User Name: " + session["UserName"]);

            // Session persists as long as the app is running
            Console.WriteLine("Session is active. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
