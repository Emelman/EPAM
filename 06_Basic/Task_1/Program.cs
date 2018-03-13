using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Employee - enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname:");
            string surN = Console.ReadLine();
            Employee somePerson = new Employee(name, surN, new DateTime(1985, 1, 31), false);
            somePerson.InitEmployee(AllCompanyAppointments.Programmer, 500, new DateTime(2011, 5, 21));
            Console.WriteLine("Get Employee data");
            Console.WriteLine("Days on work {0} as a {1}", somePerson.WorkExpirience.Days, somePerson.Appointment);
            Console.WriteLine(somePerson.Hired);
            Console.ReadKey();
        }
    }
}
