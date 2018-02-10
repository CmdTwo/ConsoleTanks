using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleTanks.Global;
using ConsoleTanks.Common;

namespace ConsoleTanks.GameRes
{
    public class Shell : GameObject
    {
        private Position NextPosition;
        private Func<Position> NextPositionHandler;
        private int Damage;

        public Shell(Position position, Direction direction) : base(Constans.ShellColor, Constans.ShellPrefab, position, 100, direction)
        {
            switch(direction)
            {
                case (Direction.Up):
                    NextPositionHandler = delegate () { NextPosition.UpdatePos(NextPosition.PosX, NextPosition.PosY - 1); return NextPosition; };
                    break;
                case (Direction.Down):
                    NextPositionHandler = delegate () { NextPosition.UpdatePos(NextPosition.PosX, NextPosition.PosY + 1); return NextPosition; };
                    break;
                case (Direction.Right):
                    NextPositionHandler = delegate () { NextPosition.UpdatePos(NextPosition.PosX + 1, NextPosition.PosY); return NextPosition; };
                    break;
                case (Direction.Left):
                    NextPositionHandler = delegate () { NextPosition.UpdatePos(NextPosition.PosX - 1, NextPosition.PosY); return NextPosition; };
                    break;
            }
            NextPosition = position;
            NextPosition = NextPositionHandler();
            Damage = 20;
            ShellLive();
        }

        private void ShellLive()
        {
            bool findedObject = false;

            while (!Map.GlobalMap.CurrentMap.IsBorder(NextPosition) || (findedObject = Map.GlobalMap.CurrentMap.Map[Position.PosY, Position.PosX].GameObj == null))
            {
                Position = NextPosition;
                NextPosition = NextPositionHandler();
                StepActionMethodRefs.Move(new Dictionary<StepActionParamTypes, object>() { { StepActionParamTypes.gameObject, this }, { StepActionParamTypes.newPosition, NextPosition } });

                Console.Clear();
                Map.GlobalMap.CurrentMap.DisplayMap();
                Console.ReadKey();                
            }
            if(findedObject)
            {
                GameObject obj = Map.GlobalMap.CurrentMap.Map[Position.PosY, Position.PosX].GameObj;
                obj.SubtractHP(Damage);
            }
            else
            {
                Map.GlobalMap.CurrentMap.Map[Position.PosY, Position.PosX].UpdateGameObject(null);
            }
        }
    }
}
