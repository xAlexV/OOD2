using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    [Serializable]
   public class Sink : Component
    {
        //fields 
        //public int currFlow;


       public Sink(int id,double x, double y, int currFlaw) : base (id, x, y, currFlaw)

        {

        }
    }
}
