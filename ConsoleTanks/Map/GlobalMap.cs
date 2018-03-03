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
        private List<Block.BlockMask> UpdateList = new List<Block.BlockMask>();

        public Block.BlockMask[,] Map { get; private set; }
        public static GlobalMap CurrentMap { get; private set; }

        public GlobalMap(int mapSize = 32)
        {
            MapSize = mapSize;
            Map = new Block.BlockMask[MapSize, MapSize];

            CurrentMap = this;

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
            //Console.SetCursorPosition(1, 5);
            //Console.Write("ffff");
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
            Map[obj.Position.PosY, obj.Position.PosX].UpdateGameObject(obj);
            obj.Destroyed += Obj_Destroyed;
        }

        private void Obj_Destroyed(GameRes.GameObject obj)
        {
            Map[obj.Position.PosY, obj.Position.PosX].UpdateGameObject(null);
        }

        public bool IsBorder(Common.Position position)
        {
            return (position.PosX <= 0 || position.PosY <= 0 || position.PosX >= MapSize - 1 || position.PosY >= MapSize - 1);            
        }

        public void AddMapCellToUpdate(Block.BlockMask block)
        {
            UpdateList.Add(block);
        }
    }
}
