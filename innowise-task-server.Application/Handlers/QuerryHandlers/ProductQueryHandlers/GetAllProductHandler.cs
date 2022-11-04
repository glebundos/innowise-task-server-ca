using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Application.Queries.ProductQueries;
using innowise_task_server.Core.Entities;
using innowise_task_server.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.QuerryHandlers.ProductQueryHandlers
{
    public class GetAllProductHandler : ProductHandlerBase, IRequestHandler<GetAllProductQuery, List<Product>>
    {
        public GetAllProductHandler(IProductRepository productRepo) : base(productRepo) { }

        public async Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return (List<Product>) await _productRepo.GetAllAsync();
        }
    }
}
