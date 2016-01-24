using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    public class AdjustableSpliter : Spliter
    {
        //field
        private int split;
        public AdjustableSpliter(int id, double x, double y, int currFlow, int split)
            : base(id, x, y, currFlow)
        {
            this.split = split;
        }

        public int GetSplit()
        {
            return split;
        }
        public override void calculateFlow(int flow)
        {
            //do smth
        }
    }
}
