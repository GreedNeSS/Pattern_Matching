using System;

namespace TypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Type Pattern *****");

            Employee bob = new Manager();
            Employee? tom = null;
            Employee ruslan = new Manager { IsOnVacation = true };
            Employee marcus = new Manager { IsOnVacation = false };

            UseEmployee_If(bob);

            UseEmployee_IfNull(bob);
            UseEmployee_IfNull(tom);

            UseEmployee_Switch(bob);
            UseEmployee_Switch(tom);

            UseEmployee_SwitchExtended(ruslan);
            UseEmployee_SwitchExtended(marcus);
        }

        static void UseEmployee_If(Employee emp)
        {
            Console.WriteLine("\n=> UseEmployee_If():");

            if (emp is Manager manager && !manager.IsOnVacation)
            {
                manager.Work();
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }
        }

        static void UseEmployee_IfNull(Employee emp)
        {
            Console.WriteLine("\n=> UseEmployee_IfNull():");

            if (emp is not null)
            {
                emp.Work();
            }
            else
            {
                Console.WriteLine("Employee is null");
            }
        }

        static void UseEmployee_Switch(Employee emp)
        {
            Console.WriteLine("\n=> UseEmployee_Switch():");

            switch (emp)
            {
                case Manager manager:
                    manager.Work();
                    break;
                case null:
                    Console.WriteLine("Object is null");
                    break;
                default:
                    Console.WriteLine("Object in not manager");
                    break;
            }
        }

        static void UseEmployee_SwitchExtended(Employee emp)
        {
            Console.WriteLine("\n=> UseEmployee_SwitchExtended():");

            switch (emp)
            {
                case Manager manager when !manager.IsOnVacation:
                    manager.Work();
                    break;
                case Manager manager when manager.IsOnVacation:
                    Console.WriteLine("Менеджер в отпуске!");
                    break;
                case null:
                    Console.WriteLine("Object is null");
                    break;
                default:
                    Console.WriteLine("Object in not manager");
                    break;
            }
        }
    }
}
