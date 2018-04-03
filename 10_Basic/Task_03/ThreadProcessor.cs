using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_03
{
    class ThreadProcessor
    {
        delegate void ThreadWork();
        private event ThreadWork work;
        private delegate void CallSleep(int arg); 
        private delegate void OverSleep(string name, int time);
        private event CallSleep startSleep;

        private int sleepTime;
        private Thread myThread;
        private ObjectToSort comparer;

        public ThreadProcessor()
        {
            
        }

        public void CreateNewThread(int _sleep = 0, string _name = "default")
        {
            sleepTime = _sleep;

            myThread = new Thread(StartThreadLogick);
            myThread.Name = _name;

            comparer = new ObjectToSort();
            comparer.myThreadName = myThread.Name;

            work += comparer.StartSort;
            comparer.Done += comparer.PrintJobDone;
            comparer.OverSleep += comparer.PrintSleepOver;
            startSleep = Thread.Sleep;
        }

        public void LaunchThread()
        {
            Console.WriteLine("Thread {0} Launched!", myThread.Name);
            if (myThread.IsAlive)
            {
                CreateNewThread(sleepTime, myThread.Name);
            }
            else
            {
                myThread.Start();
            }
        }

        public void TerminateThread()
        {
            Console.WriteLine("Thread {0} Terminated!", myThread.Name);
            myThread.Abort();
        }


        private void StartThreadLogick()
        {
            startSleep(sleepTime);
            comparer.SleepDone(sleepTime);
            
            if (work != null)
            {
                work();
            }
            comparer.SortDone();
        }

        
    }
}
