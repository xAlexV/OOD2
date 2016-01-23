using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlowNetwork
{ [Serializable]
     public class Item
    {
         //fields
         private int id;
         

         //constructor
         public Item (int id)
         {
             this.id = id;
         }

         public int ID()
         {
             return id;
         }

    }
}
