using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Figures;
using Task_4.Interfaces;

namespace Task_4.Bonuses
{
    internal class Banana : Bonus, IBonus
    {
        public string BonusName => "Banana";

        public Banana()
        {
            
        }

        public int BonusReward()
        {
            throw new NotImplementedException();
        }

        public void DrawBonus(DrawAnyObject painter)
        {
            Rectangle rect = new Rectangle(0, 0, 20, 20);
            rect.Draw(painter);
            bonusPic = rect;
        }
    }
}
