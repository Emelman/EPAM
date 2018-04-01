using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Office workout.");
            Office myPlace = new Office();
            myPlace.AddRandomWorker();
            myPlace.AddRandomWorker();
            myPlace.AddRandomWorker();
            myPlace.RandomPersonGoesAway();
            myPlace.AddRandomWorker();
            myPlace.AddRandomWorker();
            Console.ReadKey();
        }
    }
}
