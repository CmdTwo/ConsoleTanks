using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.GameRes.Tanks
{
    public class Tank : GameObject
    {
        public Fraction FractionRef { get; private set; }

        public Tank(char prefab, Fraction fraction, Common.Position position, Global.Direction direction) : base(fraction.Color, prefab, position, 100, direction)
        {
            FractionRef = fraction;
        }
    }
}
