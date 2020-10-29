using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveringDemo
{
    class Patient : IRecoverable
    {
        public void Recover()
        {
            WriteLine("I'm the Patient...Hook me up doc! I'm not going to make it - Walter White");
        }
    }
}
