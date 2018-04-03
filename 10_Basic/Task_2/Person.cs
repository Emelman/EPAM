using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public delegate void GreetMessage(Person person, DateTime time);
    public delegate void LeaveMessage(Person person);

    public class Person
    {
        string name;
        bool male;
        private delegate string Handler();
        Handler handle;
        public event GreetMessage Came;
        public event LeaveMessage Leave;

        public Person(string _name, bool _male)
        {
            Name = _name;
            Male = _male;
            handle = new Handler(MrOrMrs);
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    if (Male)
                    {
                        name = "John Dou";
                    }
                    else
                    {
                        name = "Jane Dou";
                    }
                }
                else
                {
                    name = value;
                }
            }
        }

        public bool Male
        {
            get
            {
                return male;
            }
            set
            {
                male = value;
            }
        }

        public void Greet(string anotherPerson, string handle, DateTime time)
        {
            switch (CompareTime(time))
            {
                case 0:
                    Console.WriteLine("'Good morning, {2} {0}!', - {1} said.", anotherPerson, Name, handle);
                    break;
                case 1:
                    Console.WriteLine("'Good day, {2} {0}!', - {1} said.", anotherPerson, Name, handle);
                    break;
                case -1:
                    Console.WriteLine("'Good evening, {2} {0}!', - {1} said.", anotherPerson, Name, handle);
                    break;
                default:
                    Console.WriteLine("Something Wrong");
                    break;
            }
        }

        public void TellGoodbye(string anotherPerson, string handle)
        {
            Console.WriteLine("'Goodbye, {2} {0}!', - {1} said.", anotherPerson, Name, handle);
        }

        private int CompareTime(DateTime current)
        {
            DateTime morning = new DateTime(current.Year, current.Month, current.Day, 12, 0, 0);
            DateTime evening = new DateTime(current.Year, current.Month, current.Day, 17, 0, 0);

            if (current.CompareTo(evening) == 1)
            {
                return -1;
            }
            else if (current.CompareTo(morning) == 1)
            {
                return 1;
            }
            return 0;
        }

        private string MrOrMrs()
        {
            if (Male)
            {
                return "Mr";
            }
            return "Mrs";
        }

        public void OnCame()
        {
            if (Came != null)
            {
                Came(this, DateTime.Now);
            }
        }

        public void OnLeave()
        {
            if (Leave != null)
            {
                Leave(this);
            }
        }
    }
}
