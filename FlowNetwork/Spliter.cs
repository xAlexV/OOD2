using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    [Serializable]
    public class Spliter : Component
    {
        //fields
        public List<int> NextComponents = new List<int>(); 
       public Spliter(int id,double x, double y, int currFlow) : base (id, x, y, currFlow)
       {

        }

       public List<int> GetListOfNextComponents()
       {
           return NextComponents;
       }
       public override void AddNextComponent(int id)
       {
           NextComponents.Add(id);
       }
        //methods
        public virtual void calculateFlow(int flow)
       {

       }
    }
}
