using innowise_task_server.Core.Entities;
using innowise_task_server.Infrastructure.Data;
using innowise_task_server.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using innowise_task_server.Core.Repositories;

namespace innowise_task_server.Infrastructure.Repositories
{
    public class FridgeProductRepository : Repository<FridgeProduct>, IFridgeProductRepository
    {
        public FridgeProductRepository(ServerContext serverContext) : base(serverContext) { }

        public async override Task<FridgeProduct> GetByIdAsync(Guid id)
        {
            return await _serverContext.Set<FridgeProduct>()
                .Include(fp => fp.Product)
                .Include(fp => fp.Fridge)
                .FirstOrDefaultAsync(f => f.ID == id);
        }

        public async Task<List<FridgeProduct>> AddAsync(List<FridgeProduct> fridgeProductList)
        {
            await _serverContext.Set<FridgeProduct>().AddRangeAsync(fridgeProductList);
            await _serverContext.SaveChangesAsync();
            return fridgeProductList;
        }

        public async Task<List<FridgeProduct>> GetFridgeProductByFridgeId(Guid id)
        {
            var allFridgeProducts = await _serverContext.FridgeProducts
                .Include(f => f.Fridge)
                .Include(p => p.Product)
                .ToListAsync();
                
            var neededFridgeProducts = allFridgeProducts.Where(f => f.FridgeID == id).ToList();

            return neededFridgeProducts;
        }

        public async Task<List<FridgeProduct>> FillAsync()
        {
            string storedProc = "EXEC GetFPWhereQuantity_0";
            var fridgeProductsQuantity0 = await _serverContext.FridgeProducts.FromSqlRaw(storedProc).ToListAsync();
            var filledFridgeProductList = new List<FridgeProduct>();
            foreach (var fridgeProduct in fridgeProductsQuantity0)
            {
                var productDefaultQuantity = _serverContext.Products.FirstOrDefaultAsync(p => p.ID == fridgeProduct.ProductID).Result!.DefaultQuantity;
                if (productDefaultQuantity == null) continue;
                await DeleteAsync(fridgeProduct);
                fridgeProduct.Quantity = (int)productDefaultQuantity;
                await AddAsync(fridgeProduct);
                filledFridgeProductList.Add(fridgeProduct);
            }

            return filledFridgeProductList;
        }

        public async Task<List<FridgeProduct>> UpdateAsync(List<FridgeProduct> fridgeProductList)
        {
            for (int i = 0; i < fridgeProductList.Count(); i++)
            {
                _serverContext.SetModified(fridgeProductList[i]);
            }

            await _serverContext.SaveChangesAsync();
            return fridgeProductList;
        }
    }
}
