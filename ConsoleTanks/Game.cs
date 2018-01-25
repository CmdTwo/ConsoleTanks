using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleTanks.GameRes;

namespace ConsoleTanks
{
    public class Game
    {
        GameRes.Player Player;

        List<GameRes.AI> AIList;
        public Game()
        {
            Player = GameRes.Player.Instante;
            AIList = new List<GameRes.AI>();
        }

        public void StartGame()
        {
            Global.Constans.StartGame = DateTime.Now;

            Map.GlobalMap map = new Map.GlobalMap();

            Fraction playerFraction = Global.Constans.FractionTypesLib[Global.FractionTypes.White];
            Player = new GameRes.Player(playerFraction, new GameRes.Tanks.Tank_1lvl(playerFraction, new Global.Position(1,5)));

            AIList.Add(new AI(Global.Constans.FractionTypesLib[Global.FractionTypes.Red]));
            AIList.Add(new AI(Global.Constans.FractionTypesLib[Global.FractionTypes.Blue]));

            map.AddObjectOnMap(Player.Tank);

            map.AddObjectOnMap(AIList[0].Tanks[0]);

            map.DisplayMap();

            //Map[12, 13].UpdateGameObject(new GameRes.Tanks.Tank_1lvl(Global.Constans.FractionTypesLib[Global.FractionTypes.Blue]));

            Console.ReadKey();
        }
    }
}
