using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Application.Queries.FridgeQueries;
using innowise_task_server.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.QuerryHandlers.FridgeQueryHandlers
{
    public class GetAllFridgeHandler : FridgeHandlerBase, IRequestHandler<GetAllFridgeQuery, List<Core.Entities.Fridge>>
    {
        public GetAllFridgeHandler(IFridgeRepository fridgeRepository) : base(fridgeRepository) { }

        public async Task<List<Core.Entities.Fridge>> Handle(GetAllFridgeQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Fridge>)await _fridgeRepo.GetAllAsync();
        }
    }
}
