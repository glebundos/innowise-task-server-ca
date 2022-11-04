using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Application.Queries.FridgeProductQueries;
using innowise_task_server.Core.Entities;
using innowise_task_server.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.QuerryHandlers.FridgeProductQueryHandlers
{
    public class GetAllFridgeProductByFridgeIdHandler : FridgeProductHandlerBase, IRequestHandler<GetAllFridgeProductByFridgeIdQuery, List<FridgeProduct>>
    {
        public GetAllFridgeProductByFridgeIdHandler(IFridgeProductRepository fridgeProductRepo) : base(fridgeProductRepo) { }

        public async Task<List<FridgeProduct>> Handle(GetAllFridgeProductByFridgeIdQuery request, CancellationToken cancellationToken)
        {
            return await _fridgeProductRepo.GetFridgeProductByFridgeId(request.FridgeId);
        }
    }
}
