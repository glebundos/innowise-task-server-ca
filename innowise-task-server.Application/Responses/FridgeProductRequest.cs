﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Responses
{
    public class FridgeProductRequest
    {
        public Guid FridgeID { get; set; }

        public Guid ProductID { get; set; }

        public int Quantity { get; set; }
    }
}
