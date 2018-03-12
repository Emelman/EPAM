using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class User
    {
        string name;
        string surname;
        DateTime birthDay;

        public User(string _name,string _surname, string patr = null)
        {
            Name = _name;
            Surname = _surname;
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
                    throw new ArgumentException("Name cannot be empty.");
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

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                if (value > DateTime.Now && (value.Year - DateTime.Now.Year) < 100)
                {
                    throw new ArgumentException("Wrong date!");
                }
                else
                {

                    birthDay = value;
                }
            }
        }

        public int Age
        {
            get
            {
                //DateTime.Today.Ticks
                return 6;
                
            }
        }
    }
}
