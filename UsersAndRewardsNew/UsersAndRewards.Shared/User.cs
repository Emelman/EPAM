using System;
using System.Collections.Generic;
using System.Linq;

namespace UsersAndRewards.Shared
{
	public class User
	{
        public int UserId { get; set; }
        private string firstName;
        private string surname;
        private DateTime birthdate;
        private int age;

		public List<Reward> Rewards { get; set; }

        public User(string _name, string _surname, bool _maleFemale, DateTime _birthD, string patr = null)
        {
            FirstName = _name;
            LastName = _surname;
            MaleOrFemale = _maleFemale;
            Birthdate = _birthD;
            Patronomic = patr;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty or null!");
                }
            }
        }

        public string LastName
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

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            private set
            {
                birthdate = value;
                if (value > DateTime.Now || Age > 100)
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
                age = now.Year - birthdate.Year;
                if (now.Month > birthdate.Month || (now.Month == birthdate.Month && now.Day < birthdate.Day))
                {
                    age--;
                }
                return age = DateUtils.DateDifference(DateTime.Now, birthdate);
            }
        }

        public bool Equals(User other)
        {
            if (other == null)
            {
                return false;
            }
            return true;
        }
    }
}
