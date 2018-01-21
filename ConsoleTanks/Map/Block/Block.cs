using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.Map.Block
{
    public abstract class Block
    {
        public ConsoleColor Color { get; private set; } 
        public char Prefab { get; private set; }


        protected Block(ConsoleColor color, char prefab = ' ')
        {
            Color = color;
            Prefab = prefab;
        }


    }
}
