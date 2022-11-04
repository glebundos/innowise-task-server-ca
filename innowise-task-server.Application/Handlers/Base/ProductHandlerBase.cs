using innowise_task_server.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Handlers.Base
{
    public class ProductHandlerBase
    {
        protected IProductRepository _productRepo;

        public ProductHandlerBase(IProductRepository productRepo) => _productRepo = productRepo;
    }
}
