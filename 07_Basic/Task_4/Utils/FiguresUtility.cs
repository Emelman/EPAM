using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Figures;

namespace Task_4.Utils
{
    class FiguresUtility
    {
        public static IFigure CreateRandomRect(int start, int end)
        {
            var rnd = new Random();
            IFigure rect = new Rectangle(
                            rnd.Next(start, end),
                            rnd.Next(start, end),
                            rnd.Next(start, end),
                            rnd.Next(start, end));
            return rect;
        }

    }
}
