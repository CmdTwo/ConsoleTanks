using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTanks.Global;

namespace ConsoleTanks.GameRes
{
    public class AI : GamePlayer
    {
        public List<Tanks.Tank> Tanks { get; private set; }
        public AI(Fraction fraction) : base(fraction)
        {
            Tanks = new List<GameRes.Tanks.Tank>();
            Tanks.Add(new GameRes.Tanks.Tank_1lvl(fraction, new Position(1, 2)));
            Tanks.Add(new GameRes.Tanks.Tank_1lvl(fraction, new Position(1, 4)));
            Tanks.Add(new GameRes.Tanks.Tank_1lvl(fraction, new Position(1, 3)));
        }
        public override Position GetMovePosition()
        {
            throw new NotImplementedException();
        }
    }
}
