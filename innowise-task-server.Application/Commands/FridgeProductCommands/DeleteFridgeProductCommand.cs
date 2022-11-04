using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Commands.FridgeProductCommands
{
    public class DeleteFridgeProductCommand : IRequest<Guid>
    {
        public DeleteFridgeProductCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
