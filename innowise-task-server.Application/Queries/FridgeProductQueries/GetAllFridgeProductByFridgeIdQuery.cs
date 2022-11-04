using innowise_task_server.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Queries.FridgeProductQueries
{
    public class GetAllFridgeProductByFridgeIdQuery : IRequest<List<FridgeProduct>>
    {
        public GetAllFridgeProductByFridgeIdQuery(Guid fridgeId)
        {
            FridgeId = fridgeId;
        }

        public Guid FridgeId { get;}
    }
}
