using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Options();

        }

        private static void Options()
        {
            Console.WriteLine("Create new user, enter his name:");
            string userName = Console.ReadLine();

            string dateString = "5/1/2008 8:30:52 AM";
            DateTime date1 = DateTime.Parse(dateString, CultureInfo.InvariantCulture);
            User someUser = CreateNewAlex(userName, "Borisovich", "Dromov", date1);
            Console.WriteLine("Show generated user data:");
            Console.ReadKey();

            Console.WriteLine(someUser.BirthDay);
            Console.WriteLine(someUser.Name);
            Console.WriteLine(someUser.Surname);
            Console.WriteLine(someUser.Patronomic);
            Console.WriteLine(someUser.Age);
            Console.ReadKey();
        }

        private static User CreateNewAlex(string name, string patronymic, string surname, DateTime date1)
        {
            User alex = new User();
            alex.Name = name;
            alex.Surname = surname;
            alex.Patronomic = patronymic;
            alex.BirthDay = date1;
            return alex; //brand new user
        }
    }
}
