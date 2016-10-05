using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int countoftests = Convert.ToInt32(Console.ReadLine());
            var inp = Console.ReadLine();
            //The Machinegunners played home/away game, scored x goals, and conceded y goals
            bool ishome = inp[26] == 'h';
            int scoredgoals = 0;
            int concededgoals = 0;
        }
    }
}
