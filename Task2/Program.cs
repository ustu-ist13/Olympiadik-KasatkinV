using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //int row = input[0];
            char place = input.Last();
            int row = Convert.ToInt32(input.Trim(place));
            /*
            if (row <= 2)
            {
                if (place == 'A' || place == 'D')
                    Console.WriteLine("window");
                else Console.WriteLine("aisle");
            }
            if (row > 2 && row <= 20)
            {
                if (place == 'A' || place == 'F')
                    Console.WriteLine("window");
                else Console.WriteLine("aisle");
            }
            if (row > 20 && row <= 65)
            {
                if (place == 'A' || place == 'K')
                    Console.WriteLine("window");
                else
                {
                    if (place == 'B' || place == 'E' || place == 'F' || place == 'J')
                        Console.WriteLine("neither");
                    else Console.WriteLine("aisle");
                }
            }*/

            //window
            if ((row <= 2 && (place == 'A' || place == 'D'))
                || ((row > 2 && row <= 20) && (place == 'A' || place == 'F'))
                || ((row > 20 && row <= 65) && (place == 'A' || place == 'K')))
                Console.WriteLine("window");
            //aisle
            if ((row <= 2 && !(place == 'A' || place == 'D'))
                || ((row > 2 && row <= 20) && !(place == 'A' || place == 'F'))
                || ((row > 20 && row <= 65) &&
                        !(place == 'A' || place == 'K' || place == 'B'
                        || place == 'E' || place == 'F' || place == 'J')))
                Console.WriteLine("aisle");
            //neither
            if (row > 20 && row <= 65 && (place == 'B' || place == 'E' || place == 'F' || place == 'J'))
                Console.WriteLine("neither");
            Console.ReadKey();
        }
    }
}
