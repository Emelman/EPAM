using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Office
    {
        Person john = new Person("John Danver", true);
        Person mary = new Person("Mary Scott", false);
        Person hugo = new Person("Hugo Jonson", true);
        Person marco = new Person("Marco Polo", true);
        Person jannet = new Person("Jannet Richrdson", false);
        private List<Person> people = new List<Person>();
        private List<Person> myCoworcers;
        delegate void Message(string name);

        public Office()
        {
            myCoworcers = new List<Person>() { john, mary, hugo, marco, jannet };
        }

        public void AddRandomWorker()
        {
            int index = new Random().Next(myCoworcers.Count);
            AddPeople(myCoworcers[index]);
            myCoworcers.Remove(myCoworcers[index]);
        }

        public void RandomPersonGoesAway()
        {
            int index = new Random().Next(people.Count);
            Console.WriteLine("{0} leaves workplace.", people[index].Name);
            people[index].OnLeave();
            myCoworcers.Add(people[index]);
            people.Remove(people[index]);
        }

        private void AddPeople(Person dude)
        {
            Console.WriteLine("{0} comes on work.", dude.Name);
            people.Add(dude);
            AddListeners(dude);
            dude.OnCame();
        }

        private void AddListeners(Person dude)
        {
            foreach (var m in people)
            {
                if (m != dude)
                {
                    dude.Came += m.Greet;
                    dude.Leave += m.TellGoodbye;
                }
            }
        }

        private void RemoveListeners(Person dude)
        {
            foreach (var m in people)
            {
                if (m != dude)
                {
                    dude.Came -= m.Greet;
                    dude.Leave -= m.TellGoodbye;
                }
            }
        }

        
    }
}
