﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
   public class Sink : Component
    {
        //fields 
        public int currFlow;


       public Sink(int id,double x, double y) : base (id, x, y)

        {

        }
    }
}
