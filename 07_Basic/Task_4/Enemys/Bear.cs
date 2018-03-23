using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Interfaces;

namespace Task_4.Enemys
{
    internal class Bear : AliveObject, IBeast
    {
        public void Attack(int power)
        {
            throw new NotImplementedException();
        }

        public void CountDistToHero(Point hero)
        {
            throw new NotImplementedException();
        }

        public override void InitialiseParameters()
        {
            throw new NotImplementedException();
        }

        public void Moving(double speed)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
