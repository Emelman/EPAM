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
        string appointment;
        double salary;

        public Employee(string _name, string _surName, DateTime _birthD, bool _maleFemale) : base(_name, _surName, _maleFemale, _birthD)
        {
            Hired = false;
            PermissibleEmployee();
        }

        public void InitEmployee(string app, double _salary, DateTime _hired)
        {
            Hired = true;
            HireDate = _hired;
            Appointment = app;
            Salary = _salary;
            OnVacation = false;
        }

        public void dismissedEmployee()
        {
            Hired = false;
            Appointment = AllCompanyAppointments.Dismissed;
            Salary = 0;
        }

        private void PermissibleEmployee()
        {
            if(Age < User.pensionerAge && Age < User.adultHumanAge)
            {
                throw new ArgumentException("do not satisfy staff requirements!");
            }
        }

        public TimeSpan WorkExpirience
        {
            get
            {
                return DateTime.Now.Subtract(HireDate);
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
                if (value >= BecomeAdult)
                {
                    hireDate = value;
                }
                else
                {
                    throw new ArgumentException("To erly for work!)");
                }
            }
        }

        public string Appointment
        {
            get
            {
                return appointment;
            }
            private set
            {
                switch (value)
                {
                    case AllCompanyAppointments.Cleaner:
                        break;
                    case AllCompanyAppointments.Security:
                        break;
                    case AllCompanyAppointments.Manager:
                        break;
                    case AllCompanyAppointments.Programmer:
                        break;
                    default:
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
                if(value < 0)
                {
                    throw new ArgumentException("Salary cant be negative!");
                }
                salary = value;
            }
        }

        private bool OnVacation
        {
            get;
            set;
        }
    }
}
