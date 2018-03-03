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
        Player Player;

        List<AI> AIList;
        public Game()
        {
            Player = Player.Instante;
            AIList = new List<AI>();
        }

        public void StartGame()
        {
            Global.Constans.StartGame = DateTime.Now;

            Map.GlobalMap map = new Map.GlobalMap();

            Fraction playerFraction = Global.Constans.FractionTypesLib[Global.FractionTypes.White];
            Player = new Player(playerFraction, new GameRes.Tanks.Tank_1lvl(playerFraction, new Common.Position(1, 5), Global.Direction.Up));

            AIList.Add(new AI(Global.Constans.FractionTypesLib[Global.FractionTypes.Red]));
            AIList.Add(new AI(Global.Constans.FractionTypesLib[Global.FractionTypes.Blue]));

            map.AddObjectOnMap(Player.Tank);

            map.AddObjectOnMap(AIList[1].Tanks[0]);
            map.AddObjectOnMap(AIList[1].Tanks[1]);
            map.AddObjectOnMap(AIList[1].Tanks[2]);

            map.AddObjectOnMap(new GameRes.Walls.BrickWall(new Common.Position(6, 6)));

            map.DisplayMap();
            while (true)
            {
                Common.StepAction playerAction = Player.GetStepAction();
                if (playerAction.ActionHandler(playerAction.Params))
                {

                }
                else
                {

                }
                Console.Clear();
                map.DisplayMap();
            }

            Console.ReadKey();
        }
    }
}
