using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveringDemo
{
    class FootballPlayer : IRecoverable
    {
        public void Recover()
        {
            WriteLine("I'm the football player...I didn't throw the game like Paul Crew! - Chris Rock");
        }
    }
}
