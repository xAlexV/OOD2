using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    public class Spliter : Component
    {
        //fields
       public Spliter(int id,double x, double y, Pipe myPipe) : base (id, x, y , myPipe)
       {

        }


        //methods
        public virtual void calculateFlow(int flow)
       {
            //do smth
       }
    }
}
