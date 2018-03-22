using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Figures;
using Task_4.Interfaces;

namespace Task_4.Enemys
{
    internal class Rabbit : Enemy, IBeast, IFigure
    {
        public Rabbit()
        {

        }

        public override void InitialiseParameters()
        {
            base.InitialiseParameters();
        }

        public void Attack(int power)
        {
            throw new NotImplementedException();
        }

        public void CountDistToHero(Point hero)
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
