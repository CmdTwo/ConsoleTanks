using System.Collections.Generic;
using ConsoleTanks.GameRes;
using ConsoleTanks.Common;
using System;

namespace ConsoleTanks.Global
{
    public static class StepActionMethodRefs
    {
        public static bool Move(Dictionary<StepActionParamTypes, object> _params)
        {
            //FIX
            Map.GlobalMap currrentMap = Map.GlobalMap.CurrentMap;
            Position newPosition = (Position)_params[StepActionParamTypes.newPosition];
            GameObject gameObject = (GameObject)_params[StepActionParamTypes.gameObject];

            if (!currrentMap.IsBorder(newPosition))
            {
                GameObject gameObjectOnMap = currrentMap.Map[newPosition.PosY, newPosition.PosX].GameObj;

                if (gameObjectOnMap is WallObject)
                {
                    Random rand = new Random(DateTime.Now.TimeOfDay.Milliseconds);
                    gameObjectOnMap.SubtractHP(rand.Next(40, 80));
                }
                else if (!(gameObjectOnMap is GameRes.Tanks.Tank))
                {
                    currrentMap.Map[gameObject.Position.PosY, gameObject.Position.PosX].UpdateGameObject(null);
                    gameObject.UpdatePosition(newPosition);
                    currrentMap.Map[gameObject.Position.PosY, gameObject.Position.PosX].UpdateGameObject(gameObject);
                    return true;
                }
            }
            return false;
        }
        public static bool ChangeDirection(Dictionary<StepActionParamTypes, object> _params)
        {
            GameRes.Tanks.Tank tank = (GameRes.Tanks.Tank)_params[StepActionParamTypes.gameObject];
            Direction direction = (Direction)_params[StepActionParamTypes.direction];
            tank.ChangeDirection(direction);
            return true;
        }

        public static bool Attack(Dictionary<StepActionParamTypes, object> _params)
        {
            Map.GlobalMap currrentMap = Map.GlobalMap.CurrentMap;
            GameRes.Tanks.Tank tank = (GameRes.Tanks.Tank)_params[StepActionParamTypes.gameObject];
            Direction direction = (Direction)_params[StepActionParamTypes.direction];

            Shell shell = new Shell(tank.Position, direction);
            ///////////////////////
            return true;
            ///////////////////////
        }
    }
}
