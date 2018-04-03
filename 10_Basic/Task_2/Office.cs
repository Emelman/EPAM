using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Office
    {
        delegate void GreetDelegate(string name, string pref, DateTime time);
        delegate void LeaveDelegate(string name, string pref);

        private GreetDelegate greetAll;
        private LeaveDelegate sayBy;

        public Office()
        {
            
        }

        public void PersonCame(Person p)
        {
            p.Came += this.PersonCame;
            // dude.addEventListener('Came', PersonCame);
            //dude.dispatchEvent('Came');
            p.Leave += this.PersonLeave;
            p.OnCame();
        }

        public void PersonGoesAway(Person p)
        {
            p.OnLeave();
        }

        private void RemoveListeners(Person dude)
        {
            dude.Came -= PersonCame;
            dude.Leave -= PersonLeave;
        }

        private void PersonCame(Person p, DateTime d)
        {
            Console.WriteLine("{0} comes on work.", p.Name);
            if (greetAll != null)
            {
                greetAll(p.Name, "", d);
            }

            greetAll += p.Greet;
            sayBy += p.TellGoodbye;
        }

        private void PersonLeave(Person p)
        {
            Console.WriteLine("{0} leaves workplace.", p.Name);

            greetAll -= p.Greet;
            sayBy -= p.TellGoodbye;
            RemoveListeners(p);

            if (sayBy != null)
            {
                sayBy(p.Name, "");
            }
        }

    }
}
