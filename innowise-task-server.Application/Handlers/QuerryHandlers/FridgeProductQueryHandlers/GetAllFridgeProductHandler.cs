using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Application.Queries.FridgeProductQueries;
using innowise_task_server.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.QuerryHandlers.FridgeProductQueryHandlers
{
    public class GetAllFridgeProductHandler : FridgeProductHandlerBase, IRequestHandler<GetAllFridgeProductQuery, List<Core.Entities.FridgeProduct>>
    {
        public GetAllFridgeProductHandler(IFridgeProductRepository fridgeProductRepository) : base(fridgeProductRepository) { }

        public async Task<List<Core.Entities.FridgeProduct>> Handle(GetAllFridgeProductQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.FridgeProduct>)await _fridgeProductRepo.GetAllAsync();
        }
    }
}
