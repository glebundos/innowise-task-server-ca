using innowise_task_server.Core.Entities;
using innowise_task_server.Core.Repositories;
using innowise_task_server.Infrastructure.Data;
using innowise_task_server.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Infrastructure.Repositories
{
    public class FridgeModelRepository : Repository<FridgeModel>, IFridgeModelRepository
    {
        public FridgeModelRepository(ServerContext serverContext) : base(serverContext) { }
    }
}
