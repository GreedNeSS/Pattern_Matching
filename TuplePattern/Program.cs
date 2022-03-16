using System;

namespace TuplePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Tuple Pattern *****");

            Console.WriteLine(GetWelcom("english", "morning"));
            Console.WriteLine(GetWelcom("french", "morning"));

            Console.WriteLine(GetWelcomExtend("english", "morning", "user"));
            Console.WriteLine(GetWelcomExtend("russian", "morning", "admin"));
        }

        static string GetWelcom(string lang, string dayTime)
        {
            Console.WriteLine("\n=> GetWelcom():");

            return (lang, dayTime) switch
            {
                ("english", "morning") => "Good morning",
                ("german", "morning") => "Guten Morgen",
                ("english", "evening") => "Good evening",
                ("german", "evening") => "Guten Abend",
                (_) => "Привет",
            };
        }

        static string GetWelcomExtend(string lang, string dayTime, string status)
        {
            Console.WriteLine("\n=> GetWelcom():");

            return (lang, dayTime, status) switch
            {
                ("english", "morning", _) => "Good morning",
                ("german", "morning", _) => "Guten Morgen",
                ("english", "evening", _) => "Good evening",
                ("german", "evening", _) => "Guten Abend",
                (_, _, "admin") => "Hello Admin",
                (_) => "Привет",
            };
        }
    }
}
