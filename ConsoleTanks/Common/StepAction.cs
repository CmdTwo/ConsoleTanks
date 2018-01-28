using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTanks.Global;

namespace ConsoleTanks.Common
{
    public struct StepAction
    {
        public Func<Dictionary<StepActionParamTypes, object>, bool> ActionHandler { get; private set; }
        public Dictionary<StepActionParamTypes, object> Params { get; private set; }

        public StepAction(Func<Dictionary<StepActionParamTypes, object>, bool> actionHandler, Dictionary<StepActionParamTypes, object> _params)
        {
            ActionHandler = actionHandler;
            Params = _params;
        }
    }
}
