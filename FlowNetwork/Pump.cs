using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    public class Pump : Component
    {
        //fields 
        public int maxFlow;
        public int currFlow;

       public Pump(int id,double x, double y) : base (id, x, y)
        {

        }
    }
}
