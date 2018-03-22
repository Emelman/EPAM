using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Figures;
using Task_4.Interfaces;

namespace Task_4.Bonuses
{
    internal class Cherry : Bonus, IBonus
    {
        public Cherry()
        {
            
        }

        public string BonusName => "Cherry";

        public int BonusReward()
        {
            throw new NotImplementedException();
        }

        public void DrawBonus(DrawAnyObject painter)
        {
            Ring myPreshes = new Ring(0, 0, 15, 20);
            myPreshes.Draw(painter);
            bonusPic = myPreshes;
        }
    }
}
