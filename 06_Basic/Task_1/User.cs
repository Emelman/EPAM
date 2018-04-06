using ServiceExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class User : IEquatable<User>
    {
        public static uint PensionerAge = 65;
        public static uint AdultHumanAge = 18;

        string name;
        string surname;
        DateTime birthDay;

        public User(string _name, string _surname, bool _maleFemale, DateTime _birthD, string patr = null)
        {
            Name = _name;
            Surname = _surname;
            MaleOrFemale = _maleFemale;
            BirthDay = _birthD;
            Patronomic = patr;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty or null!");
                }
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    surname = value;
                }
                else
                {
                    throw new ArgumentException("Wrong suname");
                }
            }
        }

        public string Patronomic
        {
            get;
            set;
        }

        public bool MaleOrFemale
        {
            get;
            private set;
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            private set
            {
                birthDay = value;
                if (value > DateTime.Now && Age < 100)
                {
                    throw new ArgumentException("Wrong date!");
                }
            }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - birthDay.Year;
                if (now.Month > birthDay.Month || (now.Month == birthDay.Month && now.Day < birthDay.Day))
                {
                    age--;
                }
                return age = DateUtils.DateDifference(DateTime.Now, BirthDay);
            }
        }

        public bool Equals(User other)
        {
            if(other == null)
            {
                return false;
            }
            return true;
        }
    }
}
