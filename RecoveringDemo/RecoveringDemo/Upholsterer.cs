using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveringDemo
{
    class Upholsterer : IRecoverable
    {
        public void Recover()
        {
            WriteLine("I'm the Upholsterer...Don't make me laugh doc, I might get a stitch!");
        }
    }
}
