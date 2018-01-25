using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.GameRes
{
    public abstract class GamePlayer
    {
        public Fraction Fraction { get; private set; }
        public abstract Global.Position GetMovePosition();

        public GamePlayer(Fraction fraction)
        {
            Fraction = fraction;
        }
        
    }
}
