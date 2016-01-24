using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    [Serializable]
    public class Merger : Component
    { //fields
       public Merger(int id,double x, double y, int currFlow) : base (id, x, y, currFlow)
       {
           
        }

       public override void ChangeCurrentFlow(int newFlow)
       {
           base.currFlow += newFlow;
       }
    }
    }
