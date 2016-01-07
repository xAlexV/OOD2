using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    public class AdjustableSpliter : Spliter
    {
        public AdjustableSpliter(int id, double x, double y, Pipe myPipe)
            : base(id, x, y, myPipe)
        {

        }

        public override void calculateFlow(int flow)
        {
            //do smth
        }
    }
}
