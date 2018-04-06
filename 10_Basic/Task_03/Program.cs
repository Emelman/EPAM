using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadProcessor proc = new ThreadProcessor();
            proc.CreateNewThread(2500, "MAtching");
            ThreadProcessor boc = new ThreadProcessor();
            boc.CreateNewThread(0, "Caller");
            ThreadProcessor poc = new ThreadProcessor();
            poc.CreateNewThread(1000, "faller");

            proc.LaunchThread();
            boc.LaunchThread();
            poc.LaunchThread();
            boc.TerminateThread();
            boc.LaunchThread();

            Console.ReadKey();
        }
    }
}
