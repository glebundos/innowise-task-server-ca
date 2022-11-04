using innowise_task_server.Application.Commands.FridgeProductCommands;
using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.CommandHandlers.FridgeProductCommandHandlers
{
    public class DeleteFridgeProductHandler : FridgeProductHandlerBase, IRequestHandler<DeleteFridgeProductCommand, Guid>
    {
        public DeleteFridgeProductHandler(IFridgeProductRepository fridgeProductRepository) : base(fridgeProductRepository) { }

        public async Task<Guid> Handle(DeleteFridgeProductCommand request, CancellationToken cancellationToken)
        {
            var fridgeProduct = await _fridgeProductRepo.GetByIdAsync(request.Id);
            await _fridgeProductRepo.DeleteAsync(fridgeProduct);
            return fridgeProduct.ID;
        }
    }
}
