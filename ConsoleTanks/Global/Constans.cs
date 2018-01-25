using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.Global
{
    public static class Constans
    {
        public static DateTime StartGame;
        public static Dictionary<TanksTypes, char> TanksTypesPrefabLib { get; private set; }
        public static Dictionary<BlockTypes, Map.Block.Block> BlockTypesLib { get; private set; }
        public static Dictionary<FractionTypes, GameRes.Fraction> FractionTypesLib { get; private set; }

        static Constans()
        {
            TanksTypesPrefabLib = new Dictionary<TanksTypes, Char>
            {
                { TanksTypes.Tank_1lvl, '1' }
            };

            BlockTypesLib = new Dictionary<BlockTypes, Map.Block.Block> {
                { BlockTypes.Grass, new Map.Block.GrassBlock() }
            };

            FractionTypesLib = new Dictionary<FractionTypes, GameRes.Fraction>
            {
                { FractionTypes.Blue, new GameRes.Fraction(ConsoleColor.Blue) },
                { FractionTypes.Red, new GameRes.Fraction(ConsoleColor.Red) },
                { FractionTypes.White, new GameRes.Fraction(ConsoleColor.White) }
            };
        }
    }
}
