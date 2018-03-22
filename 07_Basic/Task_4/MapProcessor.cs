using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Figures;

namespace Task_4
{
    class MapProcessor
    {
        IFigure rect;

        public MapProcessor() //default
        {
            rect = new Rectangle(0, 0, 600, 600);
            DrawAnyObject painter = new DrawAnyObject();
            rect.Draw(painter);
        }

        public MapProcessor(double _x, double _y, double _wd, double _ht)
        {
            rect = new Rectangle(_x, _y, _wd, _ht);
            DrawAnyObject painter = new DrawAnyObject();
            rect.Draw(painter);
        }

        public Point BorderX
        {
            get
            {
                return new Point(rect.X,(rect as Rectangle).Width);
            }
        }

        public Point BorderY
        {
            get
            {
                return new Point(rect.Y, (rect as Rectangle).Height);
            }
        }
    }
}
