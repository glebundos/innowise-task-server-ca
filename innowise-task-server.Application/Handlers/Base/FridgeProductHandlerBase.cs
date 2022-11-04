using innowise_task_server.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.Base
{
    public class FridgeProductHandlerBase
    {
        protected IFridgeProductRepository _fridgeProductRepo;

        public FridgeProductHandlerBase(IFridgeProductRepository fridgeProductRepo) => _fridgeProductRepo = fridgeProductRepo;
    }
}
