using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTanks.Global;
using ConsoleTanks.Common;

namespace ConsoleTanks.GameRes
{
    public class Player : GamePlayer
    {
        public Tanks.Tank Tank { get; private set; }
        public static Player Instante { get; private set; }

        public Player(Fraction fraction, Tanks.Tank tank) : base(fraction)
        {
            if (Instante == null)
                Instante = this;

            Tank = tank;
        }
        
        public override StepAction GetStepAction()
        {
            StepAction action;
            switch(Console.ReadKey().Key)
            {
                case (ConsoleKey.W):
                    {
                        action = new StepAction(StepActionMethodRefs.Move, new Dictionary<StepActionParamTypes, object> {
                            { StepActionParamTypes.newPosition, new Position(Tank.Position.PosX, Tank.Position.PosY - 1) },
                            { StepActionParamTypes.gameObject, Tank }
                        });
                        return action;
                    }
                case (ConsoleKey.S):
                    {
                        action = new StepAction(StepActionMethodRefs.Move, new Dictionary<StepActionParamTypes, object> {
                            { StepActionParamTypes.newPosition, new Position(Tank.Position.PosX, Tank.Position.PosY + 1) },
                            { StepActionParamTypes.gameObject, Tank }
                        });
                        return action;
                    }
                case (ConsoleKey.A):
                    {
                        action = new StepAction(StepActionMethodRefs.Move, new Dictionary<StepActionParamTypes, object> {
                            { StepActionParamTypes.newPosition, new Position(Tank.Position.PosX - 1, Tank.Position.PosY) },
                            { StepActionParamTypes.gameObject, Tank }
                        });
                        return action;
                    }
                case (ConsoleKey.D):
                    {
                        action = new StepAction(StepActionMethodRefs.Move, new Dictionary<StepActionParamTypes, object> {
                            { StepActionParamTypes.newPosition, new Position(Tank.Position.PosX + 1, Tank.Position.PosY) },
                            { StepActionParamTypes.gameObject, Tank }
                        });
                        return action;
                    }
                case (ConsoleKey.Spacebar):
                    {
                        action = new StepAction(StepActionMethodRefs.Attack, new Dictionary<StepActionParamTypes, object> {
                            { StepActionParamTypes.gameObject, Tank },
                            { StepActionParamTypes.direction, Tank.Direction }
                        });
                        return action;
                        break;
                    }
                default:
                    {
                        action = new StepAction(StepActionMethodRefs.Move, new Dictionary<StepActionParamTypes, object> {
                            { StepActionParamTypes.newPosition, new Position(Tank.Position.PosX, Tank.Position.PosY + 1) },
                            { StepActionParamTypes.gameObject, Tank }
                        });
                        return action;
                        break;
                    }
            }

        }
    }
}
