using innowise_task_server.Core.Entities;
using innowise_task_server.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Core.Repositories
{
    public interface IFridgeProductRepository : IRepository<FridgeProduct>
    {
        public Task<List<FridgeProduct>> GetFridgeProductByFridgeId(Guid id);

        public Task<List<FridgeProduct>> AddAsync(List<FridgeProduct> fridgeProductList);

        public Task<List<FridgeProduct>> FillAsync();

        public Task<List<FridgeProduct>> UpdateAsync(List<FridgeProduct> fridgeProductList);
    }
}
