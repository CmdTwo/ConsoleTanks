using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.Map
{
    class GlobalMap
    {
        private int MapSize;
        public Block.BlockMask[,] Map { get; private set; }

        public GlobalMap(int mapSize = 32)
        {
            MapSize = mapSize;
            Map = new Block.BlockMask[MapSize, MapSize];

            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    Map[i, j] = new Block.BlockMask(Global.Constans.BlockTypesLib[Global.BlockTypes.Grass]);
                }
            }
        }

        public void DisplayMap()
        {
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    Console.BackgroundColor = Map[i, j].Block.Color;                    
                    if (Map[i, j].GameObj != null)
                    {
                        Console.ForegroundColor = Map[i, j].GameObj.Color;
                        Console.Write(Map[i, j].GameObj.Prefab);
                    }
                    else
                    {
                        Console.Write(Map[i, j].Block.Prefab);
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        public void AddObjectOnMap(GameRes.GameObject obj)
        {
            Map[obj.Position.PosX, obj.Position.PosY].UpdateGameObject(obj);
        }
    }
}
