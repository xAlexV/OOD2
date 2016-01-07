using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlowNetwork
{
    public class Pipe : Item
    {
        //fields 
        public int maxFlow;
        public int currFlow;
        public int compId1;
        public int compId2;

        public Pipe(int id, int maxFlow, int currFlow) : base (id)
        {
            this.maxFlow = maxFlow;
            this.currFlow = currFlow;
        }
       
                                 

    }
}
