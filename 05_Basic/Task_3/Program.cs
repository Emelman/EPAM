using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three sides of the triangle, use space or letter as a separator:");
            Mark: string sides = Console.ReadLine();
            string[] parameters = SeparateOnWords(sides);
            if (parameters.Length < 3)
            {
                Console.WriteLine("Error! Wrong DATA!!!");
                goto Mark;
            }
            else
            {
                GenerateTriangle(parameters);
                
            }
        }

        private static void GenerateTriangle(string[] parameters)
        {
            try
            {
                Triangle litleAng = new Triangle(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
                if (litleAng != null)
                {
                    litleAng.PrintSides();
                }
                else
                {
                    throw new Exception("There is no triangle with such sides");
                }

                double ar = litleAng.Area();

                Console.WriteLine("Perimetr={0}", litleAng.Perimetr());
                Console.WriteLine("Sqaure={0}", litleAng.Area());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }

        private static string[] SeparateOnWords(string text)
        {
            List<char> separatorArray = new List<char>();
            for (var i = 0; i < text.Length; i++)
            {
                if (!Char.IsDigit(text[i]))
                {
                    separatorArray.Add(text[i]);
                }
            }
            string[] words = text.Split(separatorArray.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
    }
}
