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
    public class UpdateManyFridgeProductHandler : FridgeProductHandlerBase, IRequestHandler<UpdateManyFridgeProductCommand, List<FridgeProduct>>
    {
        public UpdateManyFridgeProductHandler(IFridgeProductRepository fridgeProductRepo) : base(fridgeProductRepo) { }

        public async Task<List<FridgeProduct>> Handle(UpdateManyFridgeProductCommand request, CancellationToken cancellationToken)
        {
            var fridgeProductEntitiyList = request.FridgeProducts;

            if (fridgeProductEntitiyList is null)
            {
                throw new ApplicationException("Issue with mapper");
            }

            return await _fridgeProductRepo.UpdateAsync(fridgeProductEntitiyList);
        }
    }
}
