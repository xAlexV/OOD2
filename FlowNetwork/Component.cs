using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{ 
    [Serializable]
    public class Component : Item
    {
        //fields
        public double x, y;
        public int currFlow;
        public int nextId = -1;


        public Component (int id,double x, double y, int currFlow) : base (id)
        {    
            this.x = x;
            this.y = y;
            this.currFlow = currFlow;
        }

        public virtual void AddNextComponent(int id)
        {
            nextId = id;
        }
        public System.Drawing.Point GivePoint()
        {
            return new System.Drawing.Point(Convert.ToInt32(x), Convert.ToInt32(y));
        }

        public int GiveCurrFlow()
        {
            return currFlow;
        }
        public void GetNewCoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void ChangeCurrentFlow(int newFlow)
        {
            this.currFlow = newFlow;
        }
    }
}
