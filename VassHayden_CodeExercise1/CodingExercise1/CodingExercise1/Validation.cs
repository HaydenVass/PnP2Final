using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CodingExercise1
{
    class Validation
    {
        public static int IntValidation(string x, out int y)
        {
            while (!int.TryParse(x, out y))
            {
                Console.WriteLine("Please enter a valid number.");
                x = Console.ReadLine();
            }
            return y;
        }

        // decimal validation
        public static decimal DecValidation(string x, out decimal y)
        {
            while (!decimal.TryParse(x, out y))
            {
                Console.WriteLine("please enter a valid number.");
                x = Console.ReadLine();
            }
            return y;
        }

        // float validation
        public static float FloatValidation(string x, out float y)
        {
            while (!float.TryParse(x, out y))
            {
                Console.WriteLine("please enter a valid number.");
                x = Console.ReadLine();
            }
            return y;
        }

        // is null 
        public static string NullOrEmpty(string x)
        {
            while (string.IsNullOrWhiteSpace(x))
            {
                Console.WriteLine("Please enter a valid response.");
                x = Console.ReadLine();
            }
            return x;
        }

        // validate on number of words a user puts in
        public static string Spaces(string x)
        {
            while (x.Split(' ').Length < 5)
            {
                Console.WriteLine("Please enter more words.");
                x = Console.ReadLine();
            }
            return x;
        }
        // clears console
        public static void ConsoleClear()
        {
            Console.WriteLine("Please hit a key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static int GetIntWithinRange(int min, int max)
        {
            int retVal;
            string input = Console.ReadLine();
            while ((!int.TryParse(input, out retVal)) || (retVal < min || retVal > max))
            {
                Console.WriteLine("Please make a valid selection. . . ");
                input = Console.ReadLine();
            }
            return retVal;
        }
    }
}
