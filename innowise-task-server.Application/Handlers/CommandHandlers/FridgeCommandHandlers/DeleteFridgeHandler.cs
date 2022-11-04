using innowise_task_server.Application.Commands.FridgeCommands;
using innowise_task_server.Application.Handlers.Base;
using innowise_task_server.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.CommandHandlers.FridgeCommandHandlers
{
    public class DeleteFridgeHandler : FridgeHandlerBase, IRequestHandler<DeleteFridgeCommand, Guid>
    {
        public DeleteFridgeHandler(IFridgeRepository fridgeRepository) : base(fridgeRepository) { }

        public async Task<Guid> Handle(DeleteFridgeCommand request, CancellationToken cancellationToken)
        {
            var fridge = await _fridgeRepo.GetByIdAsync(request.Id);
            await _fridgeRepo.DeleteAsync(fridge);
            return fridge.ID;
        }
    }
}
