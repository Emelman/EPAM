using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose programm state - to watch or to load(1 or 2):");

            BigBrother eay = new BigBrother(@"C:\Users\Emelman\source\repos\EPAM\12_Basic\Task_02\folderToWatch");
            int key;
            int.TryParse(Console.ReadLine(), out key);
            switch (key)
            {
                case 1:
                    eay.CreateObserver();
                    break;
                case 2:
                    eay.LoadSavedState();
                    break;
                default:
                    Console.WriteLine("Dont have such option!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
