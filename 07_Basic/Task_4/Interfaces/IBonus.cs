using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Figures;

namespace Task_4.Interfaces
{
    public interface IBonus 
    {
        void DrawBonus(DrawAnyObject painter);
        int BonusReward();
        string BonusName { get; }
    }
}
