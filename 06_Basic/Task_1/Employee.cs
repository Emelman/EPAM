using ServiceExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Employee : User
    {

        DateTime hireDate;
        double salary;
        J appointment;

        public Employee(string _name, string _surName, DateTime _birthD, 
            bool _maleFemale, J app, double _salary, DateTime _hired) 
            : base(_name, _surName, _maleFemale, _birthD)
        {
            Hired = true;
            HireDate = _hired;
            Appointment = app;
            Salary = _salary;
            OnVacation = false;
        }

        public void DismissedEmployee()
        {
            Hired = false;
            Appointment = J.Dismissed;
            Salary = 0;
        }

        private bool PermissibleEmployee()
        {
            return (Age >= User.PensionerAge && Age < User.AdultHumanAge);
        }

        public int WorkExpirience
        {
            get
            {
                return DateUtils.DateDifference(DateTime.Now, HireDate);
            }
        }

        public bool Hired { get; private set; }

        public DateTime HireDate
        {
            get
            {
                return hireDate;
            }
            private set
            {
                if (!PermissibleEmployee())
                {
                    throw new ArgumentException("do not satisfy staff requirements!");
                }
                if (value < DateTime.Now)
                {
                    hireDate = value;
                }
                else
                {
                    throw new ArgumentException("Wrong hire date!");
                }
            }
        }

        public J Appointment
        {
            get
            {
                return appointment;
            }
            private set
            {
                switch (value)
                {
                    case J.Cleaner:
                        break;
                    case J.Security:
                        break;
                    case J.Manager:
                        break;
                    case J.Programmer:
                        break;
                    case J.Dismissed:
                        throw new ArgumentException("Wrong appointment");
                }
                appointment = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cant be negative!");
                }
                salary = value;
            }
        }

        public DateTime BecomeAdult
        {
            get
            {
                return BirthDay.AddYears(18);
            }
        }

        private bool OnVacation
        {
            get;
            set;
        }
    }
}
