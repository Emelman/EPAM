using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Interfaces;

namespace Task_4
{
    public class DrawAnyObject : ICanvas
    {
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine($"Line drawn OnMap x1: {x1} y1: {y1}, x2: {x2}, y2: {y2}");
        }

        public void DrawRound(double x, double y, double r)
        {
            Console.WriteLine($"Round drawn OnMap center.x = {x}, center.y = {y}, r = {r}");
        }
    }
}
