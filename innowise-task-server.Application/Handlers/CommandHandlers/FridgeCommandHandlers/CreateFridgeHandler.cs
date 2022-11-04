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
    public class CreateFridgeHandler : FridgeHandlerBase, IRequestHandler<CreateFridgeCommand, FridgeResponse>
    {
        public CreateFridgeHandler(IFridgeRepository fridgeRepository) : base(fridgeRepository) { }

        public async Task<FridgeResponse> Handle(CreateFridgeCommand request, CancellationToken cancellationToken)
        {
            var fridgeEntitiy = FridgeMapper.Mapper.Map<Fridge>(request);

            if (fridgeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }

            var newFridge = await _fridgeRepo.AddAsync(fridgeEntitiy);
            var fridgeResponse = FridgeMapper.Mapper.Map<FridgeResponse>(newFridge);
            return fridgeResponse;
        }
    }
}
