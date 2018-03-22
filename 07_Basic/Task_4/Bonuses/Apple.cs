using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Figures;
using Task_4.Interfaces;

namespace Task_4.Bonuses
{
    internal class Apple : Bonus, IBonus
    {
        public Apple()
        {
            
        }

        public string BonusName => "Apple";

        public int BonusReward()
        {
            throw new NotImplementedException();
        }

        public void DrawBonus(DrawAnyObject painter)
        {
            Round apple = new Round(0, 0, 20);
            apple.Draw(painter);
            bonusPic = apple;
        }
    }
}
