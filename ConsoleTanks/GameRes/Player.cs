using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTanks.Global;

namespace ConsoleTanks.GameRes
{
    public class Player : GamePlayer
    {
        public Tanks.Tank Tank { get; private set; }
        public static Player Instante { get; private set; }

        public Player(Fraction fraction, Tanks.Tank tank) : base(fraction)
        {
            if (Instante == null)
                Instante = this;

            Tank = tank;
        }
        
        public override Position GetMovePosition()
        {
            Tank.Position.UpdatePos(Tank.Position.PosX, Tank.Position.PosY + 1);
            return Tank.Position;
        }
    }
}
