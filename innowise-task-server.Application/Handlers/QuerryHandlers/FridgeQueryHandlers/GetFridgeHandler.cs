using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Application.Queries.FridgeQueries;
using innowise_task_server.Application.Responses;
using innowise_task_server.Core.Entities;
using innowise_task_server.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.QuerryHandlers.FridgeQueryHandlers
{
    public class GetFridgeHandler : FridgeHandlerBase, IRequestHandler<GetFridgeQuery, Fridge>
    {
        public GetFridgeHandler(IFridgeRepository fridgeRepository) : base(fridgeRepository) { }

        public async Task<Fridge> Handle(GetFridgeQuery request, CancellationToken cancellationToken)
        {
            return await _fridgeRepo.GetByIdAsync(request.Id);
        }
    }
}
