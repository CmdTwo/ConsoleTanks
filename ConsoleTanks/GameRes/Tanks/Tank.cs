using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.GameRes.Tanks
{
    public class Tank : GameObject
    {
        public Fraction Fraction { get; private set; }
        public Tank(char prefab, Fraction fraction) : base(fraction.Color, prefab)
        {
            Fraction = fraction;
        }
    }
}
