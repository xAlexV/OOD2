using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlowNetwork
{
    [Serializable]
    public class Pipe : Item
    {
        //fields 
        private int maxFlow;
        private int currFlow;
        private int compId1;
        private int compId2;
        public List<Point> pipePoints;

        public Pipe(int id, int maxFlow, int currFlow, int id1, int id2, List<Point> pipePoints)
            : base(id)
        {
            this.maxFlow = maxFlow;
            this.currFlow = currFlow;
            this.pipePoints = pipePoints;
            compId1 = id1;
            compId2 = id2;
        }

        public int GetCurrFlow()
        {
            return currFlow;
        }
        public int GetMaxFlow()
        {
            return maxFlow;
        }
        public int GetFirstId()
        {
            return compId1;
        }
        public int GetSecondId()
        {
            return compId2;
        }
                                 

    }
}
