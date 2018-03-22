using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Interfaces
{
    interface IBeast
    {
        void Moving(double speed);
        void TakeDamage(int damage);
        void Attack(int power);
        void CountDistToHero(Point hero);
    }
}
