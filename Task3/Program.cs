using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            string[] inpfields = new string[count - 1];
            inpfields = Console.ReadLine().Split(' ');
            List<int> fields = new List<int>();
            foreach (var i in inpfields)
                fields.Add(Convert.ToInt32(i));
            int maxsum = 0;
            int middlesection = 0;
            for (int i = 0; i <= fields.Count-3; i++)
            {
                int sum = fields[i] + fields[i + 1] + fields[i + 2];
                if (sum > maxsum)
                {
                    maxsum = sum;
                    middlesection = i + 2;
                }
            }
            Console.WriteLine($"{ maxsum} {middlesection}");
            Console.ReadKey();


        }
    }
}
