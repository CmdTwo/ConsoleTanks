using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.GameRes
{
    public class Fraction
    {
        public ConsoleColor Color { get; private set; }

        public Fraction(ConsoleColor color)
        {
            Color = color;
        }
    }
}
