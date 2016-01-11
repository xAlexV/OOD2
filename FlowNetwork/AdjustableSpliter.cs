using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    public class AdjustableSpliter : Spliter
    {
        public AdjustableSpliter(int id, double x, double y)
            : base(id, x, y)
        {

        }

        public override void calculateFlow(int flow)
        {
            //do smth
        }
    }
}
