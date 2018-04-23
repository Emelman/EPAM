using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAndRewards.BL.Logic;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Options();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILogic logic = new Logic();
            Application.Run(new UserForm(logic));
        }

        private static void Options()
        {
            Console.WriteLine("Create new user, enter his name:");
            string userName = Console.ReadLine();

            string dateString = "5/1/2008 8:30:52 AM";
            DateTime date1 = DateTime.Parse(dateString, CultureInfo.InvariantCulture);
            User someUser = CreateNewAlex("Ivan", "Borisovich", "Dromov", date1);
            Console.WriteLine("Show generated user data:");

            Console.WriteLine(someUser.BirthDay);
            Console.WriteLine(someUser.Name);
            Console.WriteLine(someUser.Surname);
            Console.WriteLine(someUser.Patronomic);
            Console.WriteLine(someUser.Age);
        }

        private static User CreateNewAlex(string name, string patronymic, string surname, DateTime date1)
        {
            User alex = new User(name, surname, true, date1);
            return alex; //brand new user
        }
    }
}
