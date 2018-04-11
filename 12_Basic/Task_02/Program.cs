using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleCaller.WriteSimpleLine("Choose programm state - to watch or to load(1 or 2):");

            BigBrother eay = new BigBrother(@"C:\Users\Emelman\source\repos\EPAM\12_Basic\Task_02\folderToWatch");
            int key;
            int.TryParse(Console.ReadLine(), out key);
            switch (key)
            {
                case 1:
                    ConsoleCaller.WriteSimpleLine("Start to Observe");
                    eay.CreateObserver();
                    break;
                case 2:
                    ConsoleCaller.WriteSimpleLine("Please, print date you seek. Format - yyyyMMddHHmmss - year month day hour minutes seconds");
                    string toLoad = ConsoleCaller.ReadSimpleLine();
                    DateTime dt;
                    while (!DateTime.TryParseExact(toLoad, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out dt))
                    {
                        ConsoleCaller.WriteSimpleLine("Invalid date, please try again. Pattern is yyyyMMddHHmmss");
                        toLoad = ConsoleCaller.ReadSimpleLine();
                    }
                    eay.LoadSavedState(toLoad);
                    break;
                default:
                    ConsoleCaller.WriteSimpleLine("Dont have such option!");
                    break;
            }

            ConsoleCaller.WriteSimpleLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }
    }
}
