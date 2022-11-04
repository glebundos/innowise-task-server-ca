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
    public class FillFridgeProductWhereQuantity0Handler : FridgeProductHandlerBase, IRequestHandler<FillFridgeProductWhereQuantity0Query, List<FridgeProduct>>
    {
        public FillFridgeProductWhereQuantity0Handler(IFridgeProductRepository fridgeProductRepo) : base(fridgeProductRepo) { }

        public async Task<List<FridgeProduct>> Handle(FillFridgeProductWhereQuantity0Query request, CancellationToken cancellationToken)
        {
            return await _fridgeProductRepo.FillAsync();
        }
    }
}
