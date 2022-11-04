using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Responses
{
    public class FridgeResponse
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string? OwnerName { get; set; }

        public Guid ModelID { get; set; }
    }
}
