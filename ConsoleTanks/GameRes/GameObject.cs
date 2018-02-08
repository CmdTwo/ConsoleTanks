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
        public Common.Position Position { get; protected set; }
        public int HP { get; protected set; }

        protected GameObject(ConsoleColor color, char prefab, Common.Position position, int hp)
        {
            Color = color;
            Prefab = prefab;
            Position = position;
            HP = hp;
        }

        public void UpdatePosition(Common.Position position)
        {
            Position = position;
        }

        private void DestroyGameObject()
        {

        }

        public void SubtractHP(int hp)
        {
            HP = hp;
            if (hp == 0)
                DestroyGameObject();
        }
    }
}
