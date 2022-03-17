using System;

namespace RelationalAndLogicalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Relational and logical patterns *****");

            Console.WriteLine(Calculate(-200));
            Console.WriteLine(Calculate(0));
            Console.WriteLine(Calculate(10000));
            Console.WriteLine(Calculate(60000));
            Console.WriteLine(Calculate(200000));

            Console.WriteLine();

            Console.WriteLine(CheckAge(0));
            Console.WriteLine(CheckAge(220));
            Console.WriteLine(CheckAge(16));
            Console.WriteLine(CheckAge(30));
        }

        static decimal Calculate(decimal sum)
        {
            return sum switch
            {
                <= 0 => 0,
                < 50000 => sum * 0.05m,
                < 100000 => sum * 0.1m,
                _ => sum * 0.2m
            };
        }

        static string CheckAge(int  age)
        {
            return age switch
            {
                < 1 or > 110 => "Недействительный возраст!",
                > 1 and < 18 => "Доступ запрещён!",
                _ => "Доступ разрешен."
            };
        }
    }
}
