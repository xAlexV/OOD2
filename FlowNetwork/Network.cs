using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlowNetwork
{
     public class Network
    {
        private List<Item> items;

        public Network()
        {
            items = new List<Item>();
        }

         //methods
        public bool Remove(int idnumber)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items.ElementAt(i).id == idnumber)
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


         public void Load(String filename)
         {
             //do stuff
             this.items.Clear();
             StreamReader sr = null;
             try
             {
                 sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                 String s;
             }
             finally
             {
             }

         }

         public void Reset()
         {
             items.Clear();
         }

         public void AddItem(int id)
         {
             Item p = new Item(id);
             items.Add(p);

         }

    }
}
