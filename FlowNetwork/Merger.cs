﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    public class Merger : Component
    { //fields
       public Merger(int id,double x, double y) : base (id, x, y)
       {

        }


        //methods
        public virtual void calculateFlow(int flow)
       {
            //do smth
       }
    }
    }
