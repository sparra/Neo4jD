﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net.Graph.Neo4JD.Traversal.Germlin.Pipes
{
    public class OutPipe:Pipe
    {
        public OutPipe(string value):this()
        {
            base.SetPipeValue(value);
        }

        public OutPipe()
        {
            base.SetPipeName("out");
        }
    }
}
