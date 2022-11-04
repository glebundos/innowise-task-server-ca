using innowise_task_server.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Commands.FridgeCommands
{
    public class CreateFridgeCommand : IRequest<FridgeResponse>
    {
        public string Name { get; set; }

        public string? OwnerName { get; set; }

        public Guid ModelID { get; set; }
    }
}
