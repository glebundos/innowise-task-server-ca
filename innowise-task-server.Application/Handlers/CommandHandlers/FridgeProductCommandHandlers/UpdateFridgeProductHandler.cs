using innowise_task_server.Application.Commands.FridgeProductCommands;
using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Application.Mappers;
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
    public class UpdateFridgeProductHandler : FridgeProductHandlerBase, IRequestHandler<UpdateFridgeProductCommand, FridgeProduct>
    {
        public UpdateFridgeProductHandler(IFridgeProductRepository fridgeProductRepo) : base(fridgeProductRepo) { }

        public async Task<FridgeProduct> Handle(UpdateFridgeProductCommand request, CancellationToken cancellationToken)
        {
            var fridgeProduct = FridgeProductMapper.Mapper.Map<FridgeProduct>(request);
            return await _fridgeProductRepo.UpdateAsync(fridgeProduct);
        }
    }
}
