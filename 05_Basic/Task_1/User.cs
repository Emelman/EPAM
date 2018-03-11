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
        string patronymic;
        DateTime birthDay;
        int age;

        public string Name
        {
            get
            {
                if (name == string.Empty)
                {
                    throw (Error.InnerException);
                }
                return name;
            }
            set
            {
                if (value != string.Empty)
                {
                    name = value;
                }
                else
                {
                    throw (Error.InnerException);
                }
            }
        }

        public string Surname
        {
            get
            {
                if (surname == string.Empty)
                {
                    throw (Error.InnerException);
                }
                return surname;
            }
            set
            {
                if (value != string.Empty)
                {
                    surname = value;
                }
                else
                {
                    throw (Error.InnerException);
                }
            }
        }

        public string Patronomic
        {
            get
            {
                if (patronymic == string.Empty)
                {
                    throw (Error.InnerException);
                }
                return patronymic;
            }
            set
            {
                if (value != string.Empty)
                {
                    patronymic = value;
                }
                else
                {
                    throw (Error.InnerException);
                }
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                if (value == null)
                {
                    throw (Error.InnerException);
                }
                else
                {
                    birthDay = value;
                    DateTime current = DateTime.Today;
                    Age = current.Year - value.Year;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value < 0)
                {
                    throw (Error.InnerException);
                }
                else
                {
                    age = value;
                }
            }
        }

        public Exception Error { get; private set; }
    }
}
