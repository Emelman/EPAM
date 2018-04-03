using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_03
{
    class ThreadToRule
    {

        private int sleepTime;
        private Thread myThread;

        public ThreadToRule(int _sleep = 0, string _name = "default")
        {
            sleepTime = _sleep;
            myThread = new Thread(MainLogick);
            myThread.Name = _name;

            ObjectToSort job1 = new ObjectToSort();
            job1.myThreadName = myThread.Name;
            job1.Done += job1.PrintJobDone;
        }

        public void LaunchThread()
        {
            Console.WriteLine("Thread Launched!");
            myThread.Start();
        }

        public void MainLogick()
        {

        }

    }
}
