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
        


        public Component (int id,double x, double y) : base (id)
        {    
            this.x = x;
            this.y = y;
        }

        public System.Drawing.Point GivePoint()
        {
            return new System.Drawing.Point(Convert.ToInt32(x), Convert.ToInt32(y));
        }
    }
}
