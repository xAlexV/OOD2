using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    [Serializable]
    public class Pump : Component
    {
        //fields 
        private int maxFlow;

        public Pump(int id,double x, double y, int maxFlow, int currFlow) : base (id, x, y, currFlow)
        {
            this.maxFlow = maxFlow;
        }
    }
}
