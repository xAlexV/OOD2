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
                
                     BinaryFormatter binForm = new BinaryFormatter();
                     return (Network)binForm.Deserialize(fs);
                 
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
         public Item GetItemFromId(int id)
         {
             foreach (Item i in items)
             {
                 if (i.ID() == id)
                 {
                     return i;
                 }
             }
             return null;
         }
         public int UpdateFlow(Component type, int id, int flow)
         {
             if (id != -1)
                 if (type.GetType().ToString() == "FlowNetwork.Sink" || type.GetType().ToString() == "FlowNetwork.Merger" || type.GetType().ToString() == "FlowNetwork.Pump")
                 {
                     ((Component)GetItemFromId(id)).ChangeCurrentFlow(flow);
                     if (((Component)GetItemFromId(id)).nextId != -1)
                         UpdateFlow(((Component)GetItemFromId(id)), ((Component)GetItemFromId(id)).nextId, flow);
                     return flow;
                 }
                 else
                     if (type.GetType().ToString() == "FlowNetwork.AdjustableSpliter")
                     {
                         int split = ((AdjustableSpliter)type).GetSplit();
                         int xflow = (flow * ((AdjustableSpliter)type).GetSplit()) / 10;
                         if (((AdjustableSpliter)type).NextComponents.Count != 0)
                             if (((AdjustableSpliter)type).NextComponents[0] == id)
                             {
                                 ((Component)GetItemFromId(id)).ChangeCurrentFlow(xflow);
                                 UpdateFlow(((Component)GetItemFromId(id)), ((Component)GetItemFromId(id)).nextId, xflow);
                                 return xflow;
                             }
                             else
                             {
                                 ((Component)GetItemFromId(id)).ChangeCurrentFlow(flow - xflow);
                                 UpdateFlow(((Component)GetItemFromId(id)), ((Component)GetItemFromId(id)).nextId, flow - xflow);
                                 return flow - xflow;
                             }
                         return 100500;
                     }
                     else
                     {
                         ((Component)GetItemFromId(id)).ChangeCurrentFlow(flow / 2);
                         UpdateFlow(((Component)GetItemFromId(id)), ((Component)GetItemFromId(id)).nextId, flow / 2);
                         return flow / 2;
                     }
             else
                 return 100500;
         }

         public List<Pipe> GetListPipes()
         {
             List<Pipe> myList = new List<Pipe>();
             foreach (Item i in items)
             {
                 if (i is Pipe)
                     myList.Add((Pipe)i);
             }
             return myList;
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
