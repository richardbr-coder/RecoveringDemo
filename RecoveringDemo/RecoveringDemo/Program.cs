using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveringDemo
{
    class Program
    {
        static void Main()
        {
            WriteLine("Hey Doc, here's a few notes left for you today:\n");

            Patient p = new Patient();
            p.Recover();

            Upholsterer u = new Upholsterer();
            u.Recover();

            FootballPlayer f = new FootballPlayer();
            f.Recover();

            ReadLine();


        }
    }
}
