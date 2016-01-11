using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
     public class Network
    {
        // List<Item> myItems();
         private List<Item> items;

         //methods
         public bool Remove (int idnumber)
         {
           for (int i=0; i<items.Count; i++)
           {
             if (items.elementAt(i).id == idnumber)
             {
              items.RemoveAt(i);  // use RemoveAt
              return true;
             }         
           }
           return false;
         }

         public void Save()
         { 
             //include save as as a condition
         }


         public bool Load()
         { 
             //do stuff
             return false;
         }

         public void Reset()
         {
             items.Clear();

         }


    }
}
