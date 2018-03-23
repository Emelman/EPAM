using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Bonuses;

namespace Task_4.Enemys
{
    internal abstract class AliveObject
    {

        protected int hitPoints;
        protected double speed;
        protected double attackDist;
        protected int power;
        protected string name;
        protected int size;
        protected Point center;

        public abstract void InitialiseParameters();

    }
}
