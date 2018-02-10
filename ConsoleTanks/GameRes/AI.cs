using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTanks.Global;
using ConsoleTanks.Common;

namespace ConsoleTanks.GameRes
{
    public class AI : GamePlayer
    {
        public List<Tanks.Tank> Tanks { get; private set; }
        public AI(Fraction fraction) : base(fraction)
        {
            Tanks = new List<GameRes.Tanks.Tank>();
            Tanks.Add(new Tanks.Tank_1lvl(fraction, new Common.Position(1, 2), Direction.Down));
            Tanks.Add(new Tanks.Tank_1lvl(fraction, new Common.Position(1, 4), Direction.Down));
            Tanks.Add(new Tanks.Tank_1lvl(fraction, new Common.Position(1, 3), Direction.Down));
        }
        public override StepAction GetStepAction()
        {
            throw new NotImplementedException();
        }
    }
}
