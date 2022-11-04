using innowise_task_server.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Commands.FridgeProductCommands
{
    public class UpdateFridgeProductCommand : IRequest<FridgeProduct>
    {
        public UpdateFridgeProductCommand(Guid id, Guid fridgeID, Guid productID, int quantity)
        {
            ID = id;
            FridgeID = fridgeID;
            ProductID = productID;
            Quantity = quantity;
        }

        public Guid ID { get; }

        public Guid FridgeID { get; }

        public Guid ProductID { get; }

        public int Quantity { get; }
    }
}
