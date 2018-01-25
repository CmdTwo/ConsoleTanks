using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.Global
{
    public struct Position
    {
        public int PosX { get; private set; }
        public int PosY { get; private set; }

        public static Position NULL = new Position(0,0);

        public Position(int x, int y)
        {
            PosX = x;
            PosY = y;
        }

        public void UpdatePos(int newPosX, int newPosY)
        {
            PosX = newPosX;
            PosY = newPosY;
        }
    }
}
