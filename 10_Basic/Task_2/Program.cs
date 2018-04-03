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

            Person john = new Person("John Danver", true);
            Person mary = new Person("Mary Scott", false);
            Person hugo = new Person("Hugo Jonson", true);
            Person marco = new Person("Marco Polo", true);
            Person jannet = new Person("Jannet Richrdson", false);

            myPlace.PersonCame(john);
            myPlace.PersonCame(mary);
            myPlace.PersonCame(hugo);
            myPlace.PersonCame(marco);
            myPlace.PersonCame(jannet);


            myPlace.PersonGoesAway(john);
            myPlace.PersonGoesAway(mary);
            myPlace.PersonGoesAway(hugo);
            myPlace.PersonGoesAway(marco);
            myPlace.PersonGoesAway(jannet);
            Console.ReadKey();
        }
    }
}
