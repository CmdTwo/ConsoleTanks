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
        public int Damage { get; private set; }

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
            NextPosition = this.Position;
            this.Position = NextPositionHandler();
            Damage = 50;
            ShellLive();
        }

        private void ShellLive()
        {
            bool findedObject = Map.GlobalMap.CurrentMap.Map[NextPosition.PosY, NextPosition.PosX].GameObj != null;

            while (!findedObject && !Map.GlobalMap.CurrentMap.IsBorder(NextPosition))
            {
                StepActionMethodRefs.Move(new Dictionary<StepActionParamTypes, object>() { { StepActionParamTypes.gameObject, this }, { StepActionParamTypes.newPosition, NextPosition } });

                Position = NextPosition;

                Console.Clear();
                Map.GlobalMap.CurrentMap.DisplayMap();
                Console.ReadKey();

                NextPosition = NextPositionHandler();
                if (!Map.GlobalMap.CurrentMap.IsBorder(NextPosition))
                    findedObject = (Map.GlobalMap.CurrentMap.Map[NextPosition.PosY, NextPosition.PosX].GameObj != null);
            }
            if(findedObject)
            {                
                GameObject obj = Map.GlobalMap.CurrentMap.Map[NextPosition.PosY, NextPosition.PosX].GameObj;
                obj.SubtractHP(Damage);
                findedObject = false;
            }
            Map.GlobalMap.CurrentMap.Map[Position.PosY, Position.PosX].UpdateGameObject(null);
        }
    }
}
