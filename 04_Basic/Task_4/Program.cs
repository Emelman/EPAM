using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MeasureExecuteTime();
            
        }

        private static void MeasureExecuteTime()
        {
            TimeSpan[] strTimer = new TimeSpan[10];
            TimeSpan[] strBuilderTimer = new TimeSpan[10];
            int count = 10;
            for(var i = 0; i < 10; i++)
            {
                TimeSpan ts1 = ExecuteStringvalue(count + 100*i*i);
                strTimer[i] = ts1;
            }

            for(var i = 0; i < 10; i++)
            {
                TimeSpan ts2 = ExecuteStringBuilderValue(count + 100 * i*i);
                strBuilderTimer[i] = ts2;
            }
            
            PrintTablet(strTimer);
            PrintTablet(strBuilderTimer);
        }

        private static void PrintTablet(TimeSpan[] strTimer)
        {
            int count = 10;
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(strTimer[i].ToString() + " - {0}\n", count + 100*i*i);
            }
            Console.ReadLine();
        }

        private static TimeSpan ExecuteStringBuilderValue(int count)
        {
            StringBuilder sb = new StringBuilder();
            Stopwatch timer = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                sb.Append("*-=-=-=asdasd");
            }
            timer.Stop();
            return timer.Elapsed;
        }

        private static TimeSpan ExecuteStringvalue(int count)
        {
            string str = string.Empty;
            Stopwatch timer = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                str += "*-=-=-=asdasd";
            }
            timer.Stop();
            return timer.Elapsed;
        }
    }
}
