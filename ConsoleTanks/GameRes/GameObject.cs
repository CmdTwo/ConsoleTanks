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
        public Global.Direction Direction { get; private set; }

        protected GameObject(ConsoleColor color, char prefab, Common.Position position, int hp, Global.Direction direction)
        {
            Direction = direction;
            Color = color;
            Prefab = prefab;
            Position = position;
            HP = hp;
        }

        public void UpdatePosition(Common.Position position)
        {
            Position = position;
        }               

        public void SubtractHP(int hp)
        {
            HP -= hp;
            if (HP <= 0)
                Destroyed(this);
        }

        public void ChangeDirection(Global.Direction direction)
        {
            Direction = direction;
        }

        public event Action<GameObject> Destroyed;
    }
}
