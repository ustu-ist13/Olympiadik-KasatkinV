using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(inp[0]);
            int k = Convert.ToInt32(inp[1]);
            inp = Console.ReadLine().Split(' ');
            List<int> bumbums = new List<int>();
            foreach (var i in inp)
                bumbums.Add(Convert.ToInt32(i));
            int bbslast = 0;
            int drdslast = 0;
            foreach (var b in bumbums)
            {
                if (b > k)
                    bbslast += b - k;
                else
                    drdslast += k - b;
            }
            Console.WriteLine($"{bbslast} {drdslast}");
            Console.ReadKey();
        }
    }
}
