﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.GameRes.Tanks
{
    class Tank_1lvl : Tank
    {
        public Tank_1lvl(Fraction fraction, Common.Position position, Global.Direction direction) : base(Global.Constans.TanksTypesPrefabLib[Global.TanksTypes.Tank_1lvl], fraction, position, direction) { }
    }
}
