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
            proc.CreateNewThread(25, "MAtching");
            ThreadProcessor boc = new ThreadProcessor();
            boc.CreateNewThread(0, "Caller");
            ThreadProcessor poc = new ThreadProcessor();
            poc.CreateNewThread(10, "faller");

            proc.LaunchThread();
            boc.LaunchThread();
            poc.LaunchThread();
            boc.TerminateThread();
            boc.LaunchThread();

            Console.ReadKey();
        }

     
    }
}
