using System;

namespace PropertyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Property Pattern *****");

            Person tom = new Person
            { 
                Language = "english", Name = "Tom", Status = "user" 
            };
            Person rick = new Person
            { 
                Language = "french", Name = "Rick", Status = "user" 
            };
            Person ruslan = new Person
            { 
                Language = "english", Name = "Ruslan", Status = "admin" 
            };
            Person marcus = new Person
            { 
                Language = "german", Name = "Marcus", Status = "admin" 
            };
            Person henry = new Person
            { 
                Language = "afg", Name = "henry", Status = "admin" 
            };

            Employee greed = new Employee
            {
                Name = "Greed",
                Company = new Company { Title = "Microsoft" }
            };

            Employee dred = new Employee
            {
                Name = "Dred",
                Company = new Company { Title = "Apple" }
            };

            SayHello_If(rick);
            SayHello_If(tom);

            SayHello_IfExtended(ruslan);
            SayHello_IfExtended(rick);

            Console.WriteLine(SayHello_Switch(marcus));
            Console.WriteLine(SayHello_Switch(henry));
            Console.WriteLine(SayHello_Switch(null));

            Console.WriteLine(SayHello_InitVar(marcus));
            Console.WriteLine(SayHello_InitVar(henry));

            Console.WriteLine(SayHello_NestedObj(greed));
            Console.WriteLine(SayHello_NestedObj(dred));
        }

        static void SayHello_If(Person person)
        {
            Console.WriteLine("=> SayHello_If():");

            if (person is Person{ Language: "english"})
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Salut");
            }
        }

        static void SayHello_IfExtended(Person person)
        {
            Console.WriteLine("=> SayHello_IfExtended():");

            if (person is Person{ Language: "english", Status: "admin"})
            {
                Console.WriteLine("Hello Admin!");
            }
            else if(person is Person { Language: "french"})
            {
                Console.WriteLine("Salut");
            }
            else
            {
                Console.WriteLine("Hello");
            }
        }

        static string SayHello_Switch(Person person)
        {
            Console.WriteLine("=> SayHello_Switch():");

            return person switch
            {
                { Language: "english" } => $"Hello!",
                { Language: "german", Status: "admin" } => $"Hallo Admin!",
                { Language: "french" } => $"Salut!",
                { } => "Undefined!",
                null => "null",
            };
        }

        static string SayHello_InitVar(Person person)
        {
            Console.WriteLine("=> SayHello_InitVar():");

            return person switch
            {
                { Language: "english" } => $"Hello!",
                { Language: "german", Status:  var stat,
                    Status: "admin", Name: var name } => $"Hallo {name} {stat}!",
                { Language: "french" } => $"Salut!",
                { Language: var lan } => $"Undefined {lan}!",
                null => "null",
            };
        }

        static string SayHello_NestedObj(Employee emp)
        {
            Console.WriteLine("=> SayHello_NestedObj():");

            return emp switch
            {
                { Company: { Title: "Microsoft"} } => $"{emp.Name} works in Microsoft",
                { } => $"{emp.Name} works someware",
            };
        }
    }
}
