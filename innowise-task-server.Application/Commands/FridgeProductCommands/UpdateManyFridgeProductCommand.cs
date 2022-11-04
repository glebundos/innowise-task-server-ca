using innowise_task_server.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Commands.FridgeProductCommands
{
    public class UpdateManyFridgeProductCommand : IRequest<List<FridgeProduct>>
    {
        public List<FridgeProduct> FridgeProducts { get; set; } 
    }
}
