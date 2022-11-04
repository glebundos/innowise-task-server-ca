using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Application.Queries.FridgeModelQueries;
using innowise_task_server.Core.Entities;
using innowise_task_server.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.QuerryHandlers.FridgeModelQueryHandlers
{
    public class GetAdllFridgeModelHandler : FridgeModelHandlerBase, IRequestHandler<GetAllFridgeModelQuery, List<FridgeModel>>
    {
        public GetAdllFridgeModelHandler(IFridgeModelRepository fridgeModelRepo) : base(fridgeModelRepo) { }

        public async Task<List<FridgeModel>> Handle(GetAllFridgeModelQuery request, CancellationToken cancellationToken)
        {
            return (List<FridgeModel>)await _fridgeModelRepo.GetAllAsync();
        }
    }
}
