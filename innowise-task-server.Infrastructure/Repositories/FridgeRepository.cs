using innowise_task_server.Core.Entities;
using innowise_task_server.Core.Repositories;
using innowise_task_server.Infrastructure.Data;
using innowise_task_server.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Infrastructure.Repositories
{
    public class FridgeRepository : Repository<Fridge>, IFridgeRepository 
    {
        public FridgeRepository(ServerContext serverContext): base(serverContext) { }

        public async override Task<IReadOnlyList<Fridge>> GetAllAsync()
        {
            return await _serverContext.Set<Fridge>()
                .Include(f => f.Model)!
                .Include(f => f.Products)!
                .ThenInclude(p => p.Product)
                .ToListAsync();
        }

        public async override Task<Fridge> GetByIdAsync(Guid id)
        {
            return await _serverContext.Set<Fridge>()
                .Include(f => f.Products)!
                .ThenInclude(p => p.Product)
                .Include(f => f.Model)
                .FirstOrDefaultAsync(f => f.ID == id);
        }
    }
}
