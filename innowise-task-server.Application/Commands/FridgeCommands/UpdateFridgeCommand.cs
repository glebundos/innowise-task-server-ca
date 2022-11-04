using innowise_task_server.Application.Responses;
using innowise_task_server.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Commands.FridgeCommands
{
    public class UpdateFridgeCommand: IRequest<Fridge>
    {
        public UpdateFridgeCommand(Guid id, string name, string? ownerName, Guid modelId)
        {
            ID = id;
            Name = name;
            OwnerName = ownerName;
            ModelID = modelId;
        }

        public Guid ID { get; }

        public string Name { get; }

        public string? OwnerName { get; }

        public Guid ModelID { get; }
    }
}
