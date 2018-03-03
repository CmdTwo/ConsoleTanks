using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.GameRes.Walls
{
    public class BrickWall : WallObject
    {
        public BrickWall(Common.Position position) : base(ConsoleColor.DarkRed, position, 80, Global.Direction.Up)
        {

        }
    }
}
