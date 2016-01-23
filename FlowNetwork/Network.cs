using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FlowNetwork
{
    [Serializable]
     public class Network : ISerializable
    {
        private List<Item> items;



        public void SavePipe(int maxFlow, int currentFlow, int id1, int id2, List<Point> pointList)
        {
            Pipe p = new Pipe(items.Count(), maxFlow, currentFlow, id1, id2, pointList);
            items.Add(p);
        }
        public Network()
        {
            items = new List<Item>();
        }

        public Network(SerializationInfo information, StreamingContext scontext)
        {
            items = (List<Item>)information.GetValue("items", typeof(List<Item>));
        }


         //methods
        public bool Remove(int idnumber)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items.ElementAt(i).ID() == idnumber)
                {
                items.RemoveAt(i);  // use RemoveAt
                return true;
                }         
            }
            return false;
        }

         public static void Save(Network network, String path)
         { 
             //include save as as a condition
             using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
             {
                 BinaryFormatter binForm = new BinaryFormatter();
                 binForm.Serialize(fs, network); 
             }
         }


         public static Network Load(String path)
         {
             //do stuff
             using (FileStream fs = new FileStream(path, FileMode.Open))
             {
                 using (BinaryReader binReader = new BinaryReader(fs))
                 {
                     BinaryFormatter binForm = new BinaryFormatter();
                     return (Network)binForm.Deserialize(fs);
                 }
             }

         }

         public void GetObjectData(SerializationInfo information, StreamingContext scontext)
         {
             information.AddValue("items", items);
         }

         public void Reset()
         {
             items.Clear();
         }

         public void AddItem(Item i)
         {
             items.Add(i);
         }

         public int GetNewId()
         {
             return items.Count();
         }

         public bool FindConnection(int id)
         {
             int count = 0;
             foreach (Item p in items)
             {
                 if (p is Pipe && ((Pipe)p).GetFirstId() == id)
                 {
                     foreach (Item c in items)
                     {
                         if (c.ID() == id)
                         {
                             if (c is Spliter || c is AdjustableSpliter)
                                 count++;
                             else
                                 return false;
                         }
                     }
                 }
             }
             if (count == 2)
                 return false;
             return true;
         }

         public bool FindEndConnection(int id)
         {
             int count = 0;
             foreach (Item p in items)
             {
                 if (p is Pipe && ((Pipe)p).GetSecondId() == id)
                 {
                     foreach (Item c in items)
                     {
                         if (c.ID() == id)
                         {
                             if (c is Merger)
                                 count++;
                             else
                                 return false;
                         }
                     }
                 }
             }
             if (count == 2)
                 return false;
             return true;
         }
         public List<Item> GiveList()
         {
             return items;
         }
    }
}
