using System;

namespace PositionalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Positiona Pattern *****");

            MessageDetails details1 = new MessageDetails
            {
                Language = "english",
                DateTime = "morning",
                Status = "user"
            };

            MessageDetails details2 = new MessageDetails
            {
                Language = "russian",
                DateTime = "morning",
                Status = "admin"
            };

            MessageDetails details3 = new MessageDetails
            {
                Language = "french",
                DateTime = "morning",
                Status = "user"
            };

            Console.WriteLine(GetWelcome(details1));
            Console.WriteLine(GetWelcome(details2));
            Console.WriteLine(GetWelcome(details3));
        }

        static string GetWelcome(MessageDetails messageDetails)
        {
            Console.WriteLine("\n=> GetWelcome():");

            return messageDetails switch
            {
                ("english", "morning", _) => "Good morning",
                ("german", "morning", _) => "Guten Morgen",
                ("english", "evening", _) => "Good evening",
                ("german", "evening", _) => "Guten Abend",
                (_, _, "admin") => "Hello Admin",
                (var lang, var dateTime, var status) =>
                    $"{lang} not found, {dateTime} unknown, {status} undefined"
            };
        }
    }
}
