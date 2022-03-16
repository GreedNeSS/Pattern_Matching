using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePattern
{
    class Manager: Employee
    {
        public bool IsOnVacation { get; set; }

        public override void Work()
        {
            Console.WriteLine("Manager works");
        }
    }
}
