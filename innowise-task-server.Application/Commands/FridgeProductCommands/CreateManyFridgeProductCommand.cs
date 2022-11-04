using innowise_task_server.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Commands.FridgeProductCommands
{
    public class CreateManyFridgeProductCommand : IRequest<List<FridgeProductResponse>>
    {
        public List<FridgeProductRequest> FridgeProducts { get; set; }
    }
}
