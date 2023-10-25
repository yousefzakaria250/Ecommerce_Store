using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Interfaces
{
    public interface IProductRepo
    {
        Task<Product> GetProduct(int Id);
        Task<IReadOnlyList<Product>> GetAllProducts();
    }
}
