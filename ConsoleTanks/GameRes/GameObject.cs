using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.GameRes
{
    public abstract class GameObject
    {
        public ConsoleColor Color { get; private set; }
        public char Prefab { get; private set; }
        public Global.Position Position { get; private set; }
        protected GameObject(ConsoleColor color, char prefab, Global.Position position)
        {
            Color = color;
            Prefab = prefab;
            Position = position;
        }
    }
}
