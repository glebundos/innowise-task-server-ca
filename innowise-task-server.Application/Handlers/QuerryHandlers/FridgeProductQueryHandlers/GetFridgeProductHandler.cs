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
    public class GetFridgeProductHandler : FridgeProductHandlerBase, IRequestHandler<GetFridgeProductQuery, FridgeProduct>
    {
        public GetFridgeProductHandler(IFridgeProductRepository fridgeProductRepository) : base(fridgeProductRepository) { }

        public async Task<FridgeProduct> Handle(GetFridgeProductQuery request, CancellationToken cancellationToken)
        {
            return await _fridgeProductRepo.GetByIdAsync(request.Id);
        }
    }
}
