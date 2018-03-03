using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.GameRes
{
    public class WallObject : GameObject
    {
        public WallObject(ConsoleColor color, Common.Position position, int hp, Global.Direction direction) : base(color, Global.Constans.WallPrefab, position, hp, direction)
        {

        }


    }
}
