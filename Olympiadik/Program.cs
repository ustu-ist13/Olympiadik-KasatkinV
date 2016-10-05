using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = Convert.ToInt32(Console.ReadLine());
            if (((4*60) / 45) >= 12 - f)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
            Console.ReadKey();
        }
    }
}
