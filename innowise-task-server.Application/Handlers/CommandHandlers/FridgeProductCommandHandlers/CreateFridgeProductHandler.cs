using innowise_task_server.Application.Commands.FridgeCommands;
using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Application.Mappers;
using innowise_task_server.Application.Responses;
using innowise_task_server.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using innowise_task_server.Application.Commands.FridgeProductCommands;
using innowise_task_server.Core.Repositories;

namespace innowise_task_server.Application.Handlers.CommandHandlers.FridgeProductCommandHandlers
{
    public class CreateFridgeProductHandler : FridgeProductHandlerBase, IRequestHandler<CreateFridgeProductCommand, FridgeProductResponse>
    {
        public CreateFridgeProductHandler(IFridgeProductRepository fridgeProductRepository) : base(fridgeProductRepository) { }

        public async Task<FridgeProductResponse> Handle(CreateFridgeProductCommand request, CancellationToken cancellationToken)
        {
            var fridgeProductEntitiy = FridgeProductMapper.Mapper.Map<FridgeProduct>(request);

            if (fridgeProductEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }

            var newProductFridge = await _fridgeProductRepo.AddAsync(fridgeProductEntitiy);
            var fridgeProductResponse = FridgeProductMapper.Mapper.Map<FridgeProductResponse>(newProductFridge);
            return fridgeProductResponse;
        }
    }
}
