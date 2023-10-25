using Ecommece.Infrastructure.Data;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommece.Infrastructure.Repository.ProductRepo
{
    public class ProdcutRepo : IProductRepo
    {
        StoreContext StoreContext { get; set; }
        public ProdcutRepo(StoreContext storeContext)
        {
            StoreContext = storeContext;
        }
        public async Task<IReadOnlyList<Product>> GetAllProducts()
        {
            return
            await StoreContext.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int Id)
        {
            return
                 await StoreContext.Products.FindAsync(Id);
        }
    }
}
