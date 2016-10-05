using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char place = input.Last();
            int row = Convert.ToInt32(input.Trim(place));
            if ((row <= 2 && (place == 'A' || place == 'D'))
                || ((row > 2 && row <= 20) && (place == 'A' || place == 'F'))
                || ((row > 20 && row <= 65) && (place == 'A' || place == 'K')))
                Console.WriteLine("window");
            if ((row <= 2 && !(place == 'A' || place == 'D'))
                || ((row > 2 && row <= 20) && !(place == 'A' || place == 'F'))
                || ((row > 20 && row <= 65) &&
                        !(place == 'A' || place == 'K' || place == 'B'
                        || place == 'E' || place == 'F' || place == 'J')))
                Console.WriteLine("aisle");
            if (row > 20 && row <= 65 && (place == 'B' || place == 'E' || place == 'F' || place == 'J'))
                Console.WriteLine("neither");
            Console.ReadKey();
        }
    }
}
