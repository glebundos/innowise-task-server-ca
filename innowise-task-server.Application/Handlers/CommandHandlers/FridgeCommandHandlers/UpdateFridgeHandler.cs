using innowise_task_server.Application.Commands.FridgeCommands;
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

namespace innowise_task_server.Application.Handlers.CommandHandlers.FridgeCommandHandlers
{
    public class UpdateFridgeHandler : FridgeHandlerBase, IRequestHandler<UpdateFridgeCommand, Fridge>
    {
        public UpdateFridgeHandler(IFridgeRepository fridgeRepository) : base(fridgeRepository) { }

        public async Task<Fridge> Handle(UpdateFridgeCommand request, CancellationToken cancellationToken)
        {
            var fridge = FridgeMapper.Mapper.Map<Fridge>(request);
            return await _fridgeRepo.UpdateAsync(fridge);
        }
    }
}
