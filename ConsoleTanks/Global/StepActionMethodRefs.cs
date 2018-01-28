using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.Global
{
    public static class StepActionMethodRefs
    {
        public static bool Move(Dictionary<Global.StepActionParamTypes, object> _params)
        {
            Map.GlobalMap currrentMap = Map.GlobalMap.CurrentMap;
            Common.Position newPosition = (Common.Position)_params[StepActionParamTypes.newPosition];
            GameRes.GameObject gameObject = (GameRes.GameObject)_params[StepActionParamTypes.gameObject];

            currrentMap.Map[gameObject.Position.PosY, gameObject.Position.PosX].UpdateGameObject(null);

            gameObject.UpdatePosition(newPosition);
            currrentMap.Map[gameObject.Position.PosY, gameObject.Position.PosX].UpdateGameObject(gameObject);

            return true;
        }
        public static bool ChangeDirection(Dictionary<Global.StepActionParamTypes, object> _params)
        {
            return true;
        }

        public static bool Attack(Dictionary<Global.StepActionParamTypes, object> _params)
        {
            return true;
        }
    }
}
