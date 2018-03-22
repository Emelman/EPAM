using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Bonuses;
using Task_4.Interfaces;

namespace Task_4
{
    class BonusProcessor
    {
        List<IBonus> bonuses;

        public BonusProcessor()
        {
            bonuses = GetBonuses(10);
            
        }

        public void PaintThemAll(DrawAnyObject painter)
        {
            foreach(var m in bonuses)
            {
                m.DrawBonus(painter);
            }
        }

        private static List<IBonus> GetBonuses(int count)
        {
            var bonuses = new List<IBonus>();
            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        bonuses.Add(new Apple());
                        break;
                    case 1:
                        bonuses.Add(new Banana());
                        break;
                    case 2:
                        bonuses.Add(new Cherry());
                        break;
                    default:
                        throw new ArgumentException("Dont heve such case!");
                }
            }

            return bonuses;
        }
    }
}
