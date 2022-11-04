using innowise_task_server.Application.Commands.FridgeProductCommands;
using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Application.Mappers;
using innowise_task_server.Application.Responses;
using innowise_task_server.Core.Entities;
using innowise_task_server.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.CommandHandlers.FridgeProductCommandHandlers
{
    public class CreateManyFridgeProductHandler : FridgeProductHandlerBase, IRequestHandler<CreateManyFridgeProductCommand, List<FridgeProductResponse>>
    {
        public CreateManyFridgeProductHandler(IFridgeProductRepository fridgeProductRepo) : base(fridgeProductRepo) { }

        public async Task<List<FridgeProductResponse>> Handle(CreateManyFridgeProductCommand request, CancellationToken cancellationToken)
        {
            var fridgeProductEntitiyList = FridgeProductMapper.Mapper.Map<List<FridgeProduct>>(request.FridgeProducts);

            if (fridgeProductEntitiyList is null)
            {
                throw new ApplicationException("Issue with mapper");
            }

            var newProductFridgeList = await _fridgeProductRepo.AddAsync(fridgeProductEntitiyList);
            var fridgeProductListResponse = FridgeProductMapper.Mapper.Map<List<FridgeProductResponse>>(newProductFridgeList);
            return fridgeProductListResponse;
        }
    }
}
